using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zapper.Net.Objects.Models
{
    public class ZapperBalances
    {
        public ZapperBalanceTotals Totals { get; set; }
        public ZapperBalanceCategories Category { get; set; }
    }

    public class ZapperBalanceCategories
    {
        public Dictionary<string, ZapperBalanceCategory> Deposits { get; set; }
        public Dictionary<string, ZapperBalanceCategory> Debt { get; set; }
        public Dictionary<string, ZapperBalanceCategory> Vesting { get; set; }
        public Dictionary<string, ZapperBalanceCategory> Wallet { get; set; }
        public Dictionary<string, ZapperBalanceCategory> Claimable { get; set; }
        public Dictionary<string, ZapperBalanceCategory> Locked { get; set; }
        public Dictionary<string, ZapperBalanceCategory> Nft { get; set; }
    }

    public class ZapperBalanceCategory
    {
        public string AppId { get; set; }
        public string Address { get; set; }
        public string Network { get; set; }
        public decimal BalanceUSD { get; set; }
        public string MetaType { get; set; }
        public string Type { get; set; }
        public string ContractType { get; set; }
        public ZapperBalanceDisplay DisplayProps { get; set; }
        public ZapperBalanceContext Context { get; set; }

    }

    public class ZapperBalanceDisplay
    {
        public string Label { get; set; }
        public string SecondaryLabel { get; set; }
        public IEnumerable<string> Images { get; set; }

    }

    public class ZapperBalanceContext 
    { 
        public string Symbol { get; set; }
        public decimal Balance { get; set; }
        public int Decimals { get; set; }
        public decimal BalanceRaw { get; set; }
        public decimal Price { get; set; }
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
        public decimal NetTotalWithNfts { get; set; }
        public ZapperStats Stats { get; set; }

    }

    public class ZapperStats
    {
        public IEnumerable<ZapperHoldings> TopHoldings { get; set; }
        public IEnumerable<ZapperHoldings> TopHoldingsWithNfts { get; set; }
    }

    public class ZapperHoldings
    {
        public string AppId { get; set; }
        public string Label { get; set; }
        public decimal BalanceUSD { get; set; }
        [JsonProperty("pctHolding")]
        public decimal? PercentageHolding { get; set; }
    }
}
