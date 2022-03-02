using System;
using System.Collections.Generic;
using System.Text;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Zapper.Net.Objects.Models
{
    public class ZapperTransaction
    {
        public string Network { get; set; } = string.Empty;
        public string Hash { get; set; } = string.Empty;
        public long BlockNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Direction { get; set; } = string.Empty;
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        [JsonProperty("symbol")]
        public string Asset { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        [JsonProperty("amount")]
        public decimal Quantity { get; set; }
        public string From { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public string Contract { get; set; } = string.Empty;
        public IEnumerable<ZapperSubTransaction> SubTransactions { get; set; } = Array.Empty<ZapperSubTransaction>();
        public string Nonce { get; set; } = string.Empty;
        public decimal GasPrice { get; set; }
        public decimal GasLimit { get; set; }
        public string Input { get; set; } = string.Empty;
        public decimal Gas { get; set; }
        [JsonProperty("txSuccessful")]
        public bool Successful { get; set; }
        public string Account { get; set; } = string.Empty;
        public string DestinationENS { get; set; } = string.Empty;
        public string AccountENS { get; set; } = string.Empty;
    }

    public class ZapperSubTransaction
    {
        public string Type { get; set; } = string.Empty;
        [JsonProperty("symbol")]
        public string Asset { get; set; } = string.Empty;
        [JsonProperty("amount")]
        public decimal Quantity { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}
