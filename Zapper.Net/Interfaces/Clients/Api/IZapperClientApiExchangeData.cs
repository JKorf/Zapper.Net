using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zapper.Net.Interfaces.Clients.Api
{
    public interface IZapperClientApiExchangeData
    {
        Task<WebCallResult<Dictionary<string, decimal>>> GetUsdPricesAsync(CancellationToken ct = default);
    }
}
