using System;
using System.Collections.Generic;
using System.Net.Http;
using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Objects;

namespace Zapper.Net
{
    /// <summary>
    /// Authentication provider for the Zapper API
    /// </summary>
    public class ZapperAuthenticationProvider : AuthenticationProvider
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="credentials"></param>
        public ZapperAuthenticationProvider(ApiCredentials credentials): base(credentials)
        { }

        /// <inheritdoc />
        public override void AuthenticateRequest(RestApiClient apiClient, Uri uri, HttpMethod method, Dictionary<string, object> providedParameters, bool auth, ArrayParametersSerialization arraySerialization, HttpMethodParameterPosition parameterPosition, out SortedDictionary<string, object> uriParameters, out SortedDictionary<string, object> bodyParameters, out Dictionary<string, string> headers)
        {
            uriParameters = parameterPosition == HttpMethodParameterPosition.InUri ? new SortedDictionary<string, object>(providedParameters) : new SortedDictionary<string, object>();
            bodyParameters = parameterPosition == HttpMethodParameterPosition.InBody ? new SortedDictionary<string, object>(providedParameters) : new SortedDictionary<string, object>();
            headers = new Dictionary<string, string>();

            if (!auth)
                return;

            uriParameters.Add("api_key", Credentials.Key!.GetString());
        }
    }
}
