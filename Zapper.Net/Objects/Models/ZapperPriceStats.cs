using System;
using System.Collections.Generic;
using System.Text;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Zapper.Net.Objects.Models
{
    public class ZapperPriceStats
    {
        public string CoinGeckoId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Link { get; set; }
        public string Address { get; set; }
        [JsonProperty("ath")]
        public ZapperPriceReference AllTimeHigh { get; set; }
        [JsonProperty("atl")]
        public ZapperPriceReference AllTimeLow { get; set; }
        public Dictionary<string, long> MarketCap { get; set; }
        public int MarketCapRank { get; set; }
        public decimal CirculatingSupply { get; set; }
        public Dictionary<string, decimal> Volume24H { get; set; }
        public decimal PriceChange24H { get; set; }
        public decimal PriceChangePercentage24H { get; set; }
        public decimal PriceChangePercentage7D { get; set; }
        public decimal PriceChangePercentage30D { get; set; }
        public decimal PriceChangePercentage1Y { get; set; }
        public IEnumerable<ZapperTimePrice> Prices { get; set; }
    }

    [JsonConverter(typeof(ArrayConverter))]
    public class ZapperTimePrice
    {
        [ArrayProperty(0), JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        [ArrayProperty(1)]
        public decimal Price { get; set; }
    }

    public class ZapperPriceReference
    {
        [JsonProperty("date")]
        public Dictionary<string, DateTime> Dates { get; set; }

        [JsonProperty("price")]
        public Dictionary<string, decimal> Prices { get; set; }
        [JsonProperty("percent")]
        public Dictionary<string, decimal> Percentages { get; set; }
    }
}
