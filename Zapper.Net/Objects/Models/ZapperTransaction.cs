using System;
using System.Collections.Generic;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// Transaction info
    /// </summary>
    public class ZapperTransaction
    {
        /// <summary>
        /// Network
        /// </summary>
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// Hash
        /// </summary>
        public string Hash { get; set; } = string.Empty;
        /// <summary>
        /// Block number
        /// </summary>
        public long BlockNumber { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Direction
        /// </summary>
        public string Direction { get; set; } = string.Empty;
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// Quantity transacted
        /// </summary>
        [JsonProperty("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// From address
        /// </summary>
        public string From { get; set; } = string.Empty;
        /// <summary>
        /// To address
        /// </summary>
        public string Destination { get; set; } = string.Empty;
        /// <summary>
        /// Contract
        /// </summary>
        public string Contract { get; set; } = string.Empty;
        /// <summary>
        /// Sub transaction details
        /// </summary>
        public IEnumerable<ZapperSubTransaction> SubTransactions { get; set; } = Array.Empty<ZapperSubTransaction>();
        /// <summary>
        /// Nonace
        /// </summary>
        public string Nonce { get; set; } = string.Empty;
        /// <summary>
        /// Gas price at the time
        /// </summary>
        public decimal GasPrice { get; set; }
        /// <summary>
        /// Gas limit specified
        /// </summary>
        public decimal GasLimit { get; set; }
        /// <summary>
        /// Input
        /// </summary>
        public string Input { get; set; } = string.Empty;
        /// <summary>
        /// Gas
        /// </summary>
        public decimal Gas { get; set; }
        /// <summary>
        /// Successful
        /// </summary>
        [JsonProperty("txSuccessful")]
        public bool Successful { get; set; }
        /// <summary>
        /// Account
        /// </summary>
        public string Account { get; set; } = string.Empty;
        /// <summary>
        /// Destination ENS
        /// </summary>
        public string DestinationENS { get; set; } = string.Empty;
        /// <summary>
        /// Account ENS
        /// </summary>
        public string AccountENS { get; set; } = string.Empty;
    }

    /// <summary>
    /// Sub transaction details
    /// </summary>
    public class ZapperSubTransaction
    {
        /// <summary>
        /// Transaction type
        /// </summary>
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; } = string.Empty;
    }
}
