using System;
using System.Collections.Generic;
using System.Text;
using Zapper.Net.Interfaces.Clients.Api;

namespace Zapper.Net.Clients.Api
{
    internal class ZapperClientApiExchangeData : IZapperClientApiExchangeData
    {
        private ZapperClientApi _baseClient;

        public ZapperClientApiExchangeData(ZapperClientApi baseClient)
        {
            _baseClient = baseClient;
        }
    }
}
