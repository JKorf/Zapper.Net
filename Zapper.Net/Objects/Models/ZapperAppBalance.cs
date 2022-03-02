using System;
using System.Collections.Generic;
using System.Text;

namespace Zapper.Net.Objects.Models
{
    public class ZapperAppBalance: ZapperModel
    {
        public IEnumerable<ZapperAppBalanceMeta> Meta { get; set; }
        public IEnumerable<ZapperProduct> Products { get; set; }
    }

    public class ZapperProduct
    {
        public string Label { get; set; }
        public IEnumerable<ZapperProductAssets> Assets { get; set; }
    }

    public class ZapperProductAssets
    {
        public string Type { get; set; }
        public string Network { get; set; }
        public string Address { get; set; }
        public int Decimals { get; set; }
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public decimal Balance { get; set; }
        public string BalanceRaw { get; set; }
        public decimal BalanceUsd { get; set; }
    }

    public class ZapperAppBalanceMeta
    {
        public string Label { get; set; }
        public decimal Value { get; set; }
        public string Type { get; set; }
    }
}
