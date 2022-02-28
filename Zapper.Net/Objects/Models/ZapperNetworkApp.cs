using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Zapper.Net.Objects.Models
{
    public class ZapperNetworkAppList
    {
        public string Network { get; set; }
        public IEnumerable<ZapperNetworkApp> Apps { get; set; }
    }

    public class ZapperNetworkApp
    {
        public string AppId { get; set; }
        public ZapperNetworkAppMeta Meta { get; set; }
        public IEnumerable<string> Addresses { get; set; }
    }

    public class ZapperNetworkAppMeta
    { 
        public string Label { get; set; }
        [JsonProperty("img")]
        public string Image { get; set; }
        public IEnumerable<string> SupportedActions { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
