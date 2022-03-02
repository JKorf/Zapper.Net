using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Zapper.Net.Objects.Models
{
    public class ZapperTokenPrice
    {
        public string Address { get; set; }
        public int Decimals { get; set; }
        [JsonProperty("symbol")]
        public string Asset { get; set; }
        public decimal Price { get; set; }
    }
}
