using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zapper.Net.Objects.Models
{
    public class ZapperBalances
    {
        public ZapperBalanceTotals Totals { get; set; }
        public ZapperBalanceCategory Category { get; set; }
    }

    public class ZapperBalanceCategory
    {
    }

    public class ZapperBalanceTotals
    {
        [JsonProperty("categoriesTotal")]
        public Dictionary<string, decimal> CategoriesTotals { get; set; }
        public Dictionary<string, decimal> ClaimablePerNetwork { get; set; }
        public Dictionary<string, decimal> NetworkTotals { get; set; }
        public decimal NetTotal { get; set; }
        public decimal AssetTotal { get; set; }
        public decimal DebtTotal { get; set; }
        public ZapperStats Stats { get; set; }

    }

    public class ZapperStats
    {
        public IEnumerable<ZapperHoldings> TopHoldings { get; set; }
    }

    public class ZapperHoldings
    {
        public string AppId { get; set; }
        public string Label { get; set; }
        public decimal BalanceUSD { get; set; }
        public decimal? PctHolding { get; set; }
    }
}
