using System;
using System.Collections.Generic;
using System.Text;

namespace Zapper.Net.Interfaces.Clients.Api
{
    public interface IZapperClientApi
    {
        IZapperClientApiAccount Account { get; }
        IZapperClientApiExchangeData ExchangeData { get; }
        IZapperClientApiTrading Trading { get; }
    }
}
