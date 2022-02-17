using System;
using System.Collections.Generic;
using System.Text;
using Zapper.Net.Interfaces.Clients.Api;

namespace Zapper.Net.Interfaces.Clients
{
    public interface IZapperClient
    {
        IZapperClientApi Api { get; }
    }
}
