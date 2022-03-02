using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net;
using CryptoExchange.Net.Objects;
using Zapper.Net.Interfaces.Clients.Api;
using Zapper.Net.Objects.Internal;
using Zapper.Net.Objects.Models;

namespace Zapper.Net.Clients.Api
{
    public class ZapperClientApiAddressData : IZapperClientApiAddressData
    {
        private ZapperClientApi _baseClient;

        public ZapperClientApiAddressData(ZapperClientApi baseClient)
        {
            _baseClient = baseClient;
        }

        public Task<WebCallResult<IEnumerable<ZapperNetworkAppList>>> GetSupportedAppBalancesAsync(string address, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "addresses%5B%5D", address },
            };

            return _baseClient.SendRequestInternal<IEnumerable<ZapperNetworkAppList>>(_baseClient.GetUrl($"v1/protocols/balances/supported"), HttpMethod.Get, ct, parameters, true);
        }

        public async Task<WebCallResult<ZapperAppBalance>> GetAppBalancesAsync(string appId, string address, string? network = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "addresses%5B%5D", address },
                { "newBalances", true }
            };
            parameters.AddOptionalParameter("network", network);

            var result = await _baseClient.SendRequestInternal<Dictionary<string, ZapperAppBalance>>(_baseClient.GetUrl($"v1/apps/{appId}/balances"), HttpMethod.Get, ct, parameters, true);
            if (!result)
                return result.As<ZapperAppBalance>(default);
            
            if(!result.Data.TryGetValue(address, out var val))
                return result.AsError<ZapperAppBalance>(new ServerError("No data for address returned"));

            if (val.Error != null)
                return result.AsError<ZapperAppBalance>(new ServerError(val.Error));
            
            return result.As(val);
        }

        // --- Returns data in SSE
        //public Task<WebCallResult<ZapperBalances>> GetBalancesAsync(string address, CancellationToken ct = default)
        //{
        //    var parameters = new Dictionary<string, object>()
        //    {
        //        { "addresses%5B%5D", address },
        //        { "api_key", "96e0cc51-a62e-42ca-acee-910ea7d2a241" }
        //    };

        //    return _baseClient.SendRequestInternal<ZapperBalances>(_baseClient.GetUrl("v1/balances-v3"), HttpMethod.Get, ct, parameters, false, sseEndpoint: true);
        //}

        // --- Unknown return data
        //public Task<WebCallResult<Dictionary<string, object>>> GetStakedBalancesAsync(string balanceType, string address, string? network = null, CancellationToken ct = default)
        //{
        //    // TODO map return data
        //    var parameters = new Dictionary<string, object>()
        //    {
        //        { "addresses%5B%5D", address },
        //    };
        //    parameters.AddOptionalParameter("network", network);

        //    return _baseClient.SendRequestInternal<Dictionary<string, object>>(_baseClient.GetUrl($"v1/staked-balance/{balanceType}"), HttpMethod.Get, ct, parameters, true);
        //}

        public Task<WebCallResult<ZapperResultWrapper<ZapperTransaction>>> GetTransactionsAsync(string address, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "addresses%5B%5D", address }, // Why 2 times?
                { "address", address }
            };

            return _baseClient.SendRequestInternal<ZapperResultWrapper<ZapperTransaction>>(_baseClient.GetUrl("v1/transactions"), HttpMethod.Get, ct, parameters, true);
        }
    }
}
