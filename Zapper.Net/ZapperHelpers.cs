using System;
using Microsoft.Extensions.DependencyInjection;
using Zapper.Net.Interfaces.Clients;
using Zapper.Net.Objects;

namespace Zapper.Net
{
    /// <summary>
    /// Helper methods
    /// </summary>
    public static class ZapperHelpers
    {
        /// <summary>
        /// Add the IZapperClient to the sevice collection so they can be injected
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <param name="defaultOptionsCallback">Set default options for the client</param>
        /// <returns></returns>
        public static IServiceCollection AddBinance(
            this IServiceCollection services,
            Action<ZapperClientOptions>? defaultOptionsCallback = null)
        {
            if (defaultOptionsCallback != null)
            {
                var options = new ZapperClientOptions();
                defaultOptionsCallback?.Invoke(options);
                ZapperClient.SetDefaultOptions(options);
            }

            services.AddTransient<IZapperClient, ZapperClient>();
            return services;
        }
    }
}
