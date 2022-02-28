using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net.Objects;
using Zapper.Net.Objects.Models;

namespace Zapper.Net.Interfaces.Clients.Api
{
    public interface IZapperClientApiAccount
    {
        Task<WebCallResult<Dictionary<string, ZapperAppBalance>>> GetAppBalancesAsync(string appId, string address, string? network = null, CancellationToken ct = default);
        Task<WebCallResult<ZapperBalances>> GetBalancesAsync(string address, CancellationToken ct = default);
        Task<WebCallResult<Dictionary<string, object>>> GetStakedBalancesAsync(string balanceType, string address, string? network = null, CancellationToken ct = default);
    }
}
