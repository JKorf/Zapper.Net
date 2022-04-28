using System;
using System.Collections.Generic;

namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// Balance info
    /// </summary>
    public class ZapperAppBalances : ZapperModel
    {
        /// <summary>
        /// Balance dictionary
        /// </summary>
        public Dictionary<string, ZapperAppBalance> Balances { get; set; } = new Dictionary<string, ZapperAppBalance>();
    }

    /// <summary>
    /// App balance info
    /// </summary>
    public class ZapperAppBalance
    {
        /// <summary>
        /// Meta info on the balances
        /// </summary>
        public IEnumerable<ZapperAppBalanceMeta> Meta { get; set; } = Array.Empty<ZapperAppBalanceMeta>();
        /// <summary>
        /// Products
        /// </summary>
        public IEnumerable<ZapperProduct> Products { get; set; } = Array.Empty<ZapperProduct>();
    }

    /// <summary>
    /// Product info
    /// </summary>
    public class ZapperProduct
    {
        /// <summary>
        /// Label
        /// </summary>
        public string Label { get; set; } = string.Empty;
        /// <summary>
        /// Assets list
        /// </summary>
        public IEnumerable<ZapperProductAssets> Assets { get; set; } = Array.Empty<ZapperProductAssets>();
    }

    /// <summary>
    /// Asset info
    /// </summary>
    public class ZapperProductAssets
    {
        /// <summary>
        /// Asset type
        /// </summary>
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// Network
        /// </summary>
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// Max decimal places
        /// </summary>
        public int Decimals { get; set; }
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Balance
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Balance raw
        /// </summary>
        public string BalanceRaw { get; set; } = string.Empty;
        /// <summary>
        /// Balance in USD value
        /// </summary>
        public decimal BalanceUsd { get; set; }
    }

    /// <summary>
    /// Blance meta data
    /// </summary>
    public class ZapperAppBalanceMeta
    {
        /// <summary>
        /// Label
        /// </summary>
        public string Label { get; set; } = string.Empty;
        /// <summary>
        /// Balance value
        /// </summary>
        public decimal Value { get; set; }
        /// <summary>
        /// Balance type
        /// </summary>
        public string Type { get; set; } = string.Empty;
    }
}
