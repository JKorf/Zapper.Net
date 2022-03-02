using System;
using System.Collections.Generic;
using System.Text;

namespace Zapper.Net.Objects.Models
{
    public class ZapperApp
    {
        public string Id { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public IEnumerable<ZapperAppNetwork> SupportedNetworks { get; set; }
        public Dictionary<string, string> Groups { get; set; }
        public string PrimaryColor { get; set; }
        public ZapperAppToken Token { get; set; }
        public Dictionary<string, string> CompatibleAddressFormats { get; set; }
        public bool Disabled { get; set; }
    }
}
