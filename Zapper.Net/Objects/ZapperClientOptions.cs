using System;
using System.Collections.Generic;
using System.Text;
using CryptoExchange.Net.Objects;

namespace Zapper.Net.Objects
{
    public class ZapperClientOptions: BaseRestClientOptions
    {
        public static ZapperClientOptions Default { get; set; } = new ZapperClientOptions();

        private RestApiClientOptions _apiOptions = new RestApiClientOptions("https://api.zapper.fi/");

        /// <summary>
        /// API options
        /// </summary>
        public RestApiClientOptions ApiOptions
        {
            get => _apiOptions;
            set => _apiOptions = new RestApiClientOptions(_apiOptions, value);
        }

        /// <summary>
        /// ctor
        /// </summary>
        public ZapperClientOptions(): this(Default)
        {
        }

        public ZapperClientOptions(ZapperClientOptions baseOn): base(baseOn)
        {
            if (baseOn == null)
                return;

            ApiOptions = new RestApiClientOptions(baseOn.ApiOptions, null);
        }
    }
}
