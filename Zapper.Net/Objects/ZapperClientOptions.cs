using CryptoExchange.Net.Objects;

namespace Zapper.Net.Objects
{
    /// <summary>
    /// Options for the ZapperClient
    /// </summary>
    public class ZapperClientOptions: BaseRestClientOptions
    {
        /// <summary>
        /// Default options to use
        /// </summary>
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

        internal ZapperClientOptions(ZapperClientOptions baseOn): base(baseOn)
        {
            if (baseOn == null)
                return;

            ApiOptions = new RestApiClientOptions(baseOn.ApiOptions, null);
        }
    }
}
