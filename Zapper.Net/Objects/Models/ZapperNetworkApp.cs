using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// Network app list
    /// </summary>
    public class ZapperNetworkAppList
    {
        /// <summary>
        /// Network
        /// </summary>
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// App list
        /// </summary>
        public IEnumerable<ZapperNetworkApp> Apps { get; set; } = Array.Empty<ZapperNetworkApp>();
    }

    /// <summary>
    /// Network app info
    /// </summary>
    public class ZapperNetworkApp
    {
        /// <summary>
        /// App id
        /// </summary>
        public string AppId { get; set; } = string.Empty;
        /// <summary>
        /// Meta data
        /// </summary>
        public ZapperNetworkAppMeta Meta { get; set; } = default!;
        /// <summary>
        /// Addresses
        /// </summary>
        public IEnumerable<string> Addresses { get; set; } = Array.Empty<string>();
    }

    /// <summary>
    /// App meta data
    /// </summary>
    public class ZapperNetworkAppMeta
    { 
        /// <summary>
        /// Label
        /// </summary>
        public string Label { get; set; } = string.Empty;
        /// <summary>
        /// Image url
        /// </summary>
        [JsonProperty("img")]
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// Supported actions
        /// </summary>
        public IEnumerable<string> SupportedActions { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Tags
        /// </summary>
        public IEnumerable<string> Tags { get; set; } = Array.Empty<string>();
    }
}
