using CryptoExchange.Net;
using CryptoExchange.Net.Objects;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Zapper.Net.Interfaces.Clients.Api;
using Zapper.Net.Objects.Models;

namespace Zapper.Net.Clients.Api
{
    internal class ZapperClientApiGeneralData : IZapperClientApiGeneralData
    {
        private ZapperClientApi _baseClient;

        public ZapperClientApiGeneralData(ZapperClientApi baseClient)
        {
            _baseClient = baseClient;
        }

        public Task<WebCallResult<IEnumerable<ZapperTokenPrice>>> GetPricesAsync(string? network = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("network", network);

            return _baseClient.SendRequestInternal<IEnumerable<ZapperTokenPrice>>(_baseClient.GetUrl("v1/prices"), HttpMethod.Get, ct, parameters, true);
        }

        public Task<WebCallResult<Dictionary<string, decimal>>> GetUsdPricesAsync(CancellationToken ct = default)
        {
            return _baseClient.SendRequestInternal<Dictionary<string, decimal>>(_baseClient.GetUrl("v1/fiat-rates"), HttpMethod.Get, ct, default, true);
        }

        public Task<WebCallResult<ZapperPriceStats>> GetPriceStatsAsync(string tokenAddress, string? network = null, string? timeFrame = null, string? currency = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("network", network);
            parameters.AddOptionalParameter("timeFrame", timeFrame);
            parameters.AddOptionalParameter("currency", currency);

            return _baseClient.SendRequestInternal<ZapperPriceStats>(_baseClient.GetUrl("v1/prices/" + tokenAddress), HttpMethod.Get, ct, parameters, true);
        }

        public Task<WebCallResult<ZapperApp>> GetAppAsync(string appId, CancellationToken ct = default)
        {
            return _baseClient.SendRequestInternal<ZapperApp>(_baseClient.GetUrl($"v1/apps-v3/{appId}"), HttpMethod.Get, ct, default, false);
        }

        public Task<WebCallResult<IEnumerable<ZapperApp>>> GetAppsAsync(CancellationToken ct = default)
        {
            return _baseClient.SendRequestInternal<IEnumerable<ZapperApp>>(_baseClient.GetUrl("v1/apps-v3"), HttpMethod.Get, ct, default, false);
        }

        public Task<WebCallResult<IEnumerable<ZapperFarmStats>>> GetFarmStatsAsync(string farmStatsType, string? network = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>();
            parameters.AddOptionalParameter("network", network);

            return _baseClient.SendRequestInternal<IEnumerable<ZapperFarmStats>>(_baseClient.GetUrl($"v1/farms/{farmStatsType}"), HttpMethod.Get, ct, parameters, true);
        }

        public async Task<WebCallResult<IEnumerable<ZapperToken>>> GetTokenListAsync(CancellationToken ct = default)
        {
            var result = await _baseClient.SendRequestInternal<ZapperTokenList>(_baseClient.GetUrl($"v1/token-list"), HttpMethod.Get, ct, default, true);
            return result.As(result.Data?.Tokens)!;
        }
    }
}
