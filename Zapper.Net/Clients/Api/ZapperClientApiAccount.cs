using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net;
using CryptoExchange.Net.Objects;
using Zapper.Net.Interfaces.Clients.Api;
using Zapper.Net.Objects.Models;

namespace Zapper.Net.Clients.Api
{
    public class ZapperClientApiAccount: IZapperClientApiAccount
    {
        private ZapperClientApi _baseClient;

        public ZapperClientApiAccount(ZapperClientApi baseClient)
        {
            _baseClient = baseClient;
        }

        public Task<WebCallResult<Dictionary<string, ZapperAppBalance>>> GetAppBalancesAsync(string appId, string address, string? network = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "addresses%5B%5D", address },
                { "api_key", "96e0cc51-a62e-42ca-acee-910ea7d2a241" },
                { "newBalances", true }
            };
            parameters.AddOptionalParameter("network", network);

            return _baseClient.SendRequestInternal<Dictionary<string, ZapperAppBalance>>(_baseClient.GetUrl($"v1/protocols/{appId}/balances"), HttpMethod.Get, ct, parameters, false);
        }

        public Task<WebCallResult<ZapperBalances>> GetBalancesAsync(string address, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "addresses%5B%5D", address },
                { "api_key", "96e0cc51-a62e-42ca-acee-910ea7d2a241" }
            };

            return _baseClient.SendRequestInternal<ZapperBalances>(_baseClient.GetUrl("v1/balances-v3"), HttpMethod.Get, ct, parameters, false, sseEndpoint: true);
        }

        public Task<WebCallResult<Dictionary<string, object>>> GetStakedBalancesAsync(string balanceType, string address, string? network = null, CancellationToken ct = default)
        {
            // TODO map return data
            var parameters = new Dictionary<string, object>()
            {
                { "addresses%5B%5D", address },
                { "api_key", "96e0cc51-a62e-42ca-acee-910ea7d2a241" }
            };
            parameters.AddOptionalParameter("network", network);

            return _baseClient.SendRequestInternal<Dictionary<string, object>>(_baseClient.GetUrl($"v1/staked-balance/{balanceType}"), HttpMethod.Get, ct, parameters, false);
        }
    }
}
