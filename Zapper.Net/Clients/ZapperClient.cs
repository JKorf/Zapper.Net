using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net;
using CryptoExchange.Net.Objects;
using Zapper.Net.Clients.Api;
using Zapper.Net.Interfaces.Clients;
using Zapper.Net.Interfaces.Clients.Api;
using Zapper.Net.Objects;

namespace Zapper.Net
{
    /// <inheritdoc />
    public class ZapperClient: BaseRestClient, IZapperClient
    {
        #region Api clients

        /// <inheritdoc />
        public IZapperClientApi Api { get; }

        #endregion

        #region constructor/destructor
        /// <summary>
        /// Create a new instance of BinanceClient using the default options
        /// </summary>
        public ZapperClient() : this(ZapperClientOptions.Default)
        {
        }

        /// <summary>
        /// Create a new instance of BinanceClient using provided options
        /// </summary>
        /// <param name="options">The options to use for this client</param>
        public ZapperClient(ZapperClientOptions options) : base("Zapper", options)
        {
            Api = AddApiClient(new ZapperClientApi(log, this, options));
        }
        #endregion

        /// <summary>
        /// Set the default options to be used when creating new clients
        /// </summary>
        /// <param name="options">Options to use as default</param>
        public static void SetDefaultOptions(ZapperClientOptions options)
        {
            ZapperClientOptions.Default = options;
        }

        internal Task<WebCallResult<T>> SendRequestInternal<T>(RestApiClient apiClient, Uri uri, HttpMethod method, CancellationToken cancellationToken,
            Dictionary<string, object>? parameters = null, bool signed = false, HttpMethodParameterPosition? postPosition = null,
            ArrayParametersSerialization? arraySerialization = null, int weight = 1) where T : class
        {
            return base.SendRequestAsync<T>(apiClient, uri, method, cancellationToken, parameters, signed, postPosition, arraySerialization, requestWeight: weight);
        }
    }
}
