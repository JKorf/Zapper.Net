using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net;
using CryptoExchange.Net.Objects;
using Zapper.Net.Interfaces.Clients.Api;
using Zapper.Net.Objects.Models;

namespace Zapper.Net.Clients.Api
{
    /// <inheritdoc />
    public class ZapperClientApiAddressData : IZapperClientApiAddressData
    {
        private readonly ZapperClientApi _baseClient;

        internal ZapperClientApiAddressData(ZapperClientApi baseClient)
        {
            _baseClient = baseClient;
        }

        /// <inheritdoc />
        public Task<WebCallResult<IEnumerable<ZapperNetworkAppList>>> GetSupportedAppBalancesAsync(string address, CancellationToken ct = default)
            => GetSupportedAppBalancesAsync(new string[] { address }, ct);

        /// <inheritdoc />
        public Task<WebCallResult<IEnumerable<ZapperNetworkAppList>>> GetSupportedAppBalancesAsync(IEnumerable<string> addresses, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "addresses", addresses.ToArray() },
            };

            return _baseClient.SendRequestInternal<IEnumerable<ZapperNetworkAppList>>(_baseClient.GetUrl($"v1/protocols/balances/supported"), HttpMethod.Get, ct, parameters, true);
        }

        /// <inheritdoc />
        public async Task<WebCallResult<ZapperAppBalance>> GetAppBalancesAsync(string appId, string address, string? network = null, CancellationToken ct = default)
        {
            var result = await GetAppBalancesAsync(appId, new[] { address }, network, ct).ConfigureAwait(false);
            if(!result)
                return result.As<ZapperAppBalance>(default);

            if (!result.Data.TryGetValue(address, out var val))
                return result.AsError<ZapperAppBalance>(new ServerError("No data for address returned"));

            return result.As(val);
        }

        /// <inheritdoc />
        public Task<WebCallResult<Dictionary<string, ZapperAppBalance>>> GetAppBalancesAsync(string appId, IEnumerable<string> addresses, string? network = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "addresses", addresses.ToArray() },
                { "newBalances", true }
            };

            parameters.AddOptionalParameter("network", network);

            return _baseClient.SendRequestInternal<Dictionary<string, ZapperAppBalance>>(_baseClient.GetUrl($"v1/apps/{appId}/balances"), HttpMethod.Get, ct, parameters, true);
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

        /// <inheritdoc />
        public Task<WebCallResult<ZapperResultWrapper<ZapperTransaction>>> GetTransactionsAsync(string address, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>()
            {
                { "addresses", new [] { address } }, // Why 2 times?
                { "address", address }
            };

            return _baseClient.SendRequestInternal<ZapperResultWrapper<ZapperTransaction>>(_baseClient.GetUrl("v1/transactions"), HttpMethod.Get, ct, parameters, true);
        }
    }
}
