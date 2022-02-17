using System;
using System.Collections.Generic;
using System.Text;
using CryptoExchange.Net.Objects;

namespace Zapper.Net.Objects
{
    public class ZapperClientOptions: BaseRestClientOptions
    {
        public static ZapperClientOptions Default { get; set; } = new ZapperClientOptions();

        private readonly RestApiClientOptions _apiOptions = new RestApiClientOptions("https://api.zapper.fi/");

        /// <summary>
        /// API options
        /// </summary>
        public RestApiClientOptions ApiOptions
        {
            get => _apiOptions;
            set => _apiOptions.Copy(_apiOptions, value);
        }

        /// <summary>
        /// ctor
        /// </summary>
        public ZapperClientOptions()
        {
            if (Default == null)
                return;

            Copy(this, Default);
        }

        /// <summary>
        /// Copy the values of the def to the input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="def"></param>
        public new void Copy<T>(T input, T def) where T : ZapperClientOptions
        {
            base.Copy(input, def);

            input.ApiOptions = new RestApiClientOptions(def.ApiOptions);
        }
    }
}
