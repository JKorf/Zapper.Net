using CryptoExchange.Net.Objects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Zapper.Net.Objects.Models;

namespace Zapper.Net.Interfaces.Clients.Api
{
    /// <summary>
    /// General data endpoints
    /// </summary>
    public interface IZapperClientApiGeneralData
    {
        /// <summary>
        /// Get USD - fiat prices in the form of [1 dollar = X asset]
        /// </summary>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<Dictionary<string, decimal>>> GetUsdPricesAsync(CancellationToken ct = default);
        /// <summary>
        /// Get token prices in USD
        /// </summary>
        /// <param name="network">Filter by network</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<ZapperTokenPrice>>> GetPricesAsync(string? network = null, CancellationToken ct = default);
        /// <summary>
        /// Get price statistics for a token address
        /// </summary>
        /// <param name="tokenAddress">The address of the token</param>
        /// <param name="network"></param>
        /// <param name="timeFrame">The time frame for which to give the price history</param>
        /// <param name="currency">The currency in which to return the price history</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<ZapperPriceStats>> GetPriceStatsAsync(string tokenAddress, string? network = null, string? timeFrame = null, string? currency = null, CancellationToken ct = default);
        /// <summary>
        /// Get a list of supported tokens
        /// </summary>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<ZapperToken>>> GetTokenListAsync(CancellationToken ct = default);
        /// <summary>
        /// Get a list of supported apps
        /// </summary>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<ZapperApp>>> GetAppsAsync(CancellationToken ct = default);
        /// <summary>
        /// Get an app by id
        /// </summary>
        /// <param name="appId">The id of the app to retrieve</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<ZapperApp>> GetAppAsync(string appId, CancellationToken ct = default);
        /// <summary>
        /// Get farm statistics
        /// </summary>
        /// <param name="farmStatsType">Farm stats type</param>
        /// <param name="network">Filter by network</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<WebCallResult<IEnumerable<ZapperFarmStats>>> GetFarmStatsAsync(string farmStatsType, string? network = null, CancellationToken ct = default);
    }
}
