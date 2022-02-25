using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net;
using CryptoExchange.Net.DataProcessors;
using CryptoExchange.Net.Objects;
using Newtonsoft.Json;
using Zapper.Net.Clients.Api;
using Zapper.Net.Interfaces.Clients;
using Zapper.Net.Interfaces.Clients.Api;
using Zapper.Net.Objects;

namespace Zapper.Net
{
    public class ZapperClient: BaseRestClient, IZapperClient
    {
        #region Api clients

        /// <inheritdoc />
        public IZapperClientApi Api { get; }

        private readonly SSEJsonDataConverter _sseProcessor;

        #endregion

        /// <summary>
        /// A default serializer
        /// </summary>
        private static readonly JsonSerializer defaultSerializer = JsonSerializer.Create(new JsonSerializerSettings
        {
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            Culture = CultureInfo.InvariantCulture
        });

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
            Api = AddApiClient(new ZapperClientApi(log, this, options, new JsonDataConverter(log, defaultSerializer)));

            manualParseError = true;
            requestBodyEmptyContent = "";
            requestBodyFormat = RequestBodyFormat.FormData;
            arraySerialization = ArrayParametersSerialization.MultipleValues;
            _sseProcessor = new SSEJsonDataConverter(log, defaultSerializer);
        }
        #endregion

        internal Task<WebCallResult<T>> SendRequestInternal<T>(RestApiClient apiClient, Uri uri, HttpMethod method, CancellationToken cancellationToken,
            Dictionary<string, object>? parameters = null, bool signed = false, HttpMethodParameterPosition? postPosition = null,
            ArrayParametersSerialization? arraySerialization = null, int weight = 1, bool sseEndpoint = false) where T : class
        {
            return base.SendRequestAsync<T>(apiClient, uri, method, cancellationToken, parameters, signed, postPosition, arraySerialization, requestWeight: weight, converter: sseEndpoint ? _sseProcessor: null);
        }
    }
}
