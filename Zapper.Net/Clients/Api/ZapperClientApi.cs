﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Logging;
using CryptoExchange.Net.Objects;
using Zapper.Net.Interfaces.Clients.Api;
using Zapper.Net.Objects;

namespace Zapper.Net.Clients.Api
{
    /// <inheritdoc />
    public class ZapperClientApi : RestApiClient, IZapperClientApi
    {
        private readonly ZapperClient _baseClient;
        private readonly Log _log;
        internal new readonly ZapperClientOptions Options;

        #region Api clients
        /// <inheritdoc />
        public IZapperClientApiAddressData AddressData { get; }
        /// <inheritdoc />
        public IZapperClientApiGeneralData GeneralData { get; }
        #endregion

        #region constructor/destructor
        internal ZapperClientApi(Log log, ZapperClient baseClient, ZapperClientOptions options/*, IDataConverter dataConverter*/) : base(options, options.ApiOptions/*, dataConverter*/)
        {
            Options = options;
            _log = log;
            _baseClient = baseClient;

            AddressData = new ZapperClientApiAddressData(this);
            GeneralData = new ZapperClientApiGeneralData(this);

            manualParseError = true;
            requestBodyEmptyContent = "";
            requestBodyFormat = RequestBodyFormat.FormData;
            arraySerialization = ArrayParametersSerialization.Array;
        }
        #endregion

        /// <inheritdoc />
        protected override AuthenticationProvider CreateAuthenticationProvider(ApiCredentials credentials)
        {
            return new ZapperAuthenticationProvider(credentials);
        }

        /// <inheritdoc />
        public override TimeSpan GetTimeOffset() => TimeSpan.Zero;

        /// <inheritdoc />
        protected override Task<WebCallResult<DateTime>> GetServerTimestampAsync() => 
            Task.FromResult(new WebCallResult<DateTime>(null, null, null, null, null, null, null, null, DateTime.UtcNow, null));

        /// <inheritdoc />
        protected override TimeSyncInfo GetTimeSyncInfo()
            => new TimeSyncInfo(_log, Options.ApiOptions.AutoTimestamp, Options.ApiOptions.TimestampRecalculationInterval, new TimeSyncState("Zapper Api") { LastSyncTime = DateTime.UtcNow } );

        internal Uri GetUrl(string endpoint)
        {
            return new Uri(BaseAddress.AppendPath(endpoint));
        }

        internal async Task<WebCallResult<T>> SendRequestInternal<T>(Uri uri, HttpMethod method, CancellationToken cancellationToken,
            Dictionary<string, object>? parameters = null, bool signed = false, HttpMethodParameterPosition? postPosition = null,
            ArrayParametersSerialization? arraySerialization = null, int weight = 1) where T : class
        {
            return await _baseClient.SendRequestInternal<T>(this, uri, method, cancellationToken, parameters, signed, postPosition, arraySerialization, weight).ConfigureAwait(false);
        }
    }
}
