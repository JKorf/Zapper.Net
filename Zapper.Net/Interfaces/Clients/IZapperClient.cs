using Zapper.Net.Interfaces.Clients.Api;

namespace Zapper.Net.Interfaces.Clients
{
    /// <summary>
    /// Client for accessing the Zapper API
    /// </summary>
    public interface IZapperClient
    {
        /// <summary>
        /// Api endpoints
        /// </summary>
        IZapperClientApi Api { get; }
    }
}
