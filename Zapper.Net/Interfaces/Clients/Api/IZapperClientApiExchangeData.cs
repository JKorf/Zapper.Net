using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zapper.Net.Objects.Models;

namespace Zapper.Net.Interfaces.Clients.Api
{
    public interface IZapperClientApiExchangeData
    {
        Task<WebCallResult<Dictionary<string, decimal>>> GetUsdPricesAsync(CancellationToken ct = default);
        Task<WebCallResult<IEnumerable<ZapperApp>>> GetAppsAsync(CancellationToken ct = default);
        Task<WebCallResult<ZapperApp>> GetAppAsync(string appId, CancellationToken ct = default);
        Task<WebCallResult<IEnumerable<ZapperNetworkAppList>>> GetSupportedAppBalancesAsync(string address, CancellationToken ct = default);
    }
}
