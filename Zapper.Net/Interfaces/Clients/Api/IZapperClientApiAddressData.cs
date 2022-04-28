using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net.Objects;
using Zapper.Net.Objects.Models;

namespace Zapper.Net.Interfaces.Clients.Api
{
    /// <summary>
    /// Endpoints related to a specific address
    /// </summary>
    public interface IZapperClientApiAddressData
    {
        /// <summary>
        /// Get apps which support the GetAppBalancesAsync endpoint
        /// </summary>
        /// <param name="address">Address</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<ZapperNetworkAppList>>> GetSupportedAppBalancesAsync(string address, CancellationToken ct = default);
        
        /// <summary>
        /// Get apps which support the GetAppBalancesAsync endpoint
        /// </summary>
        /// <param name="addresses">Addresses</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<ZapperNetworkAppList>>> GetSupportedAppBalancesAsync(IEnumerable<string> addresses, CancellationToken ct = default);

        /// <summary>
        /// Get balances for an app
        /// </summary>
        /// <param name="appId">The id of the app to retrieve balances for (`tokens` for token info)</param>
        /// <param name="address">Address to retrieve balances for</param>
        /// <param name="network">Filter by network</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<ZapperAppBalance>> GetAppBalancesAsync(string appId, string address, string? network = null, CancellationToken ct = default);

        /// <summary>
        /// Get balances for an app
        /// </summary>
        /// <param name="appId">The id of the app to retrieve balances for (`tokens` for token info)</param>
        /// <param name="addresses">Addresses to retrieve balances for</param>
        /// <param name="network">Filter by network</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<ZapperAppBalances>> GetAppBalancesAsync(string appId, IEnumerable<string> addresses, string? network = null, CancellationToken ct = default);

        //Task<WebCallResult<ZapperBalances>> GetBalancesAsync(string address, CancellationToken ct = default);

        //Task<WebCallResult<Dictionary<string, object>>> GetStakedBalancesAsync(string balanceType, string address, string? network = null, CancellationToken ct = default);

        /// <summary>
        /// Get transaction history for an address
        /// </summary>
        /// <param name="address">The address to retrieve history for</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<ZapperResultWrapper<ZapperTransaction>>> GetTransactionsAsync(string address, CancellationToken ct = default);
    }
}
