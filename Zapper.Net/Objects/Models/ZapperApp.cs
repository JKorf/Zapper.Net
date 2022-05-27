using System;
using System.Collections.Generic;

namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// Zapper App
    /// </summary>
    public class ZapperApp
    {
        /// <summary>
        /// Id of the app
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// Tags for app
        /// </summary>
        public IEnumerable<string> Tags { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Name of the app
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// URL to app homepage
        /// </summary>
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// Supported networks
        /// </summary>
        public IEnumerable<ZapperAppNetwork> SupportedNetworks { get; set; } = Array.Empty<ZapperAppNetwork>();
        /// <summary>
        /// Primary color code
        /// </summary>
        public string PrimaryColor { get; set; } = string.Empty;
        /// <summary>
        /// App token info
        /// </summary>
        public ZapperAppToken Token { get; set; } = default!;
        /// <summary>
        /// Compatible address formats
        /// </summary>
        public Dictionary<string, string> CompatibleAddressFormats { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Is disabled
        /// </summary>
        public bool Disabled { get; set; }
    }
}
