using System;
using System.Collections.Generic;
using System.Text;
using Zapper.Net.Interfaces.Clients.Api;

namespace Zapper.Net.Clients.Api
{
    public class ZapperClientApiTrading: IZapperClientApiTrading
    {
        private ZapperClientApi _baseClient;

        public ZapperClientApiTrading(ZapperClientApi baseClient)
        {
            _baseClient = baseClient;
        }
    }
}
