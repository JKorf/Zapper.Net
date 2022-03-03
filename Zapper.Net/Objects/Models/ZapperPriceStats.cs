using System;
using System.Collections.Generic;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// Price history and statistics
    /// </summary>
    public class ZapperPriceStats
    {
        /// <summary>
        /// CoinGecko Id
        /// </summary>
        public string CoinGeckoId { get; set; } = string.Empty;
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Link
        /// </summary>
        public string Link { get; set; } = string.Empty;
        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// All time high info
        /// </summary>
        [JsonProperty("ath")]
        public ZapperPriceReference AllTimeHigh { get; set; } = default!;
        /// <summary>
        /// All time low info
        /// </summary>
        [JsonProperty("atl")]
        public ZapperPriceReference AllTimeLow { get; set; } = default!;
        /// <summary>
        /// Market cap in different currencies
        /// </summary>
        public Dictionary<string, long> MarketCap { get; set; } = new Dictionary<string, long>();
        /// <summary>
        /// Market cap rank
        /// </summary>
        public int MarketCapRank { get; set; }
        /// <summary>
        /// Circulating supply
        /// </summary>
        public decimal CirculatingSupply { get; set; }
        /// <summary>
        /// 24H volume
        /// </summary>
        public Dictionary<string, decimal> Volume24H { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// Price change since 24 hours ago
        /// </summary>
        public decimal PriceChange24H { get; set; }
        /// <summary>
        /// Price percentage change since 24 hours ago
        /// </summary>
        public decimal PriceChangePercentage24H { get; set; }
        /// <summary>
        /// Price percentage change since 7 days ago
        /// </summary>
        public decimal PriceChangePercentage7D { get; set; }
        /// <summary>
        /// Price percentage change since 30 days ago
        /// </summary>
        public decimal PriceChangePercentage30D { get; set; }
        /// <summary>
        /// Price percentage change since 1 year ago
        /// </summary>
        public decimal PriceChangePercentage1Y { get; set; }
        /// <summary>
        /// Price data
        /// </summary>
        public IEnumerable<ZapperTimePrice> Prices { get; set; } = Array.Empty<ZapperTimePrice>();
    }

    /// <summary>
    /// Price on a specific time
    /// </summary>
    [JsonConverter(typeof(ArrayConverter))]
    public class ZapperTimePrice
    {
        /// <summary>
        /// The timestamp of the price
        /// </summary>
        [ArrayProperty(0), JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// The price at the time
        /// </summary>
        [ArrayProperty(1)]
        public decimal Price { get; set; }
    }

    /// <summary>
    /// Price stats
    /// </summary>
    public class ZapperPriceReference
    {
        /// <summary>
        /// Timestamps this info is for for different currencies
        /// </summary>
        [JsonProperty("date")]
        public Dictionary<string, DateTime> Dates { get; set; } = new Dictionary<string, DateTime>();
        /// <summary>
        /// The price in different currencies
        /// </summary>
        [JsonProperty("price")]
        public Dictionary<string, decimal> Prices { get; set; } = new Dictionary<string, decimal>();
        /// <summary>
        /// The percentage change now vs these prices
        /// </summary>
        [JsonProperty("percent")]
        public Dictionary<string, decimal> Percentages { get; set; } = new Dictionary<string, decimal>();
    }
}
