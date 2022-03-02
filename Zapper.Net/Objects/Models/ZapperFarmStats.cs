using System;
using System.Collections.Generic;
using System.Text;

namespace Zapper.Net.Objects.Models
{
    public class ZapperFarmStats
    {
        public int PoolIndex { get; set; }
        public string StakingStrategy { get; set; } = string.Empty;
        public string FarmName { get; set; } = string.Empty;
        public string RewardAddress { get; set; } = string.Empty;
        public string TokenAddress { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string Label { get; set; } = string.Empty;
        public string AppId { get; set; } = string.Empty;
        public decimal? DailyROI { get; set; }
        public decimal? WeeklyROI { get; set; }
        public decimal? YearlyROI { get; set; }
        public decimal ValueLockedUSD { get; set; }
        public IEnumerable<ZapperRewardToken> RewardTokens { get; set; } = Array.Empty<ZapperRewardToken>();
    }

    public class ZapperRewardToken
    {
        public string Address { get; set; } = string.Empty;
        public int Decimals { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
