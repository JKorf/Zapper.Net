using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net.Objects;
using Zapper.Net.Interfaces.Clients.Api;

namespace Zapper.Net.Clients.Api
{
    public class ZapperClientApiAccount: IZapperClientApiAccount
    {
        private ZapperClientApi _baseClient;

        public ZapperClientApiAccount(ZapperClientApi baseClient)
        {
            _baseClient = baseClient;
        }

        public Task<WebCallResult<string>> GetBalancesAsync(string address, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "addresses%5B%5D", address },
                { "api_key", "96e0cc51-a62e-42ca-acee-910ea7d2a241" }
            };

            return _baseClient.SendRequestInternal<string>(_baseClient.GetUrl("v1/balances-v3"), HttpMethod.Get, ct, parameters, false);
        }
    }
}
