using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net.Objects;

namespace Zapper.Net.Interfaces.Clients.Api
{
    public interface IZapperClientApiAccount
    {
        Task<WebCallResult<string>> GetBalancesAsync(string address, CancellationToken ct = default);
    }
}
