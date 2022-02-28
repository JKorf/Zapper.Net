using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zapper.Net.Interfaces.Clients.Api;
using Zapper.Net.Objects.Models;

namespace Zapper.Net.Clients.Api
{
    internal class ZapperClientApiExchangeData : IZapperClientApiExchangeData
    {
        private ZapperClientApi _baseClient;

        public ZapperClientApiExchangeData(ZapperClientApi baseClient)
        {
            _baseClient = baseClient;
        }

        public Task<WebCallResult<Dictionary<string, decimal>>> GetUsdPricesAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "api_key", "96e0cc51-a62e-42ca-acee-910ea7d2a241" }
            };

            return _baseClient.SendRequestInternal<Dictionary<string, decimal>>(_baseClient.GetUrl("v1/fiat-rates"), HttpMethod.Get, ct, parameters, false);
        }

        public Task<WebCallResult<ZapperApp>> GetAppAsync(string appId, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "api_key", "96e0cc51-a62e-42ca-acee-910ea7d2a241" }
            };

            return _baseClient.SendRequestInternal<ZapperApp>(_baseClient.GetUrl($"v1/apps/{appId}"), HttpMethod.Get, ct, parameters, false);
        }

        public Task<WebCallResult<IEnumerable<ZapperApp>>> GetAppsAsync(CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "api_key", "96e0cc51-a62e-42ca-acee-910ea7d2a241" }
            };

            return _baseClient.SendRequestInternal<IEnumerable<ZapperApp>>(_baseClient.GetUrl("v1/apps"), HttpMethod.Get, ct, parameters, false);
        }

        public Task<WebCallResult<IEnumerable<ZapperNetworkAppList>>> GetSupportedAppBalancesAsync(string address, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "api_key", "96e0cc51-a62e-42ca-acee-910ea7d2a241" },
                { "addresses%5B%5D", address },
            };

            return _baseClient.SendRequestInternal<IEnumerable<ZapperNetworkAppList>>(_baseClient.GetUrl($"v1/protocols/balances/supported"), HttpMethod.Get, ct, parameters, false);
        }
    }
}
