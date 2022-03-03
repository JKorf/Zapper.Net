using System;
using System.Collections.Generic;

namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// Farm stats
    /// </summary>
    public class ZapperFarmStats
    {
        /// <summary>
        /// Pool index
        /// </summary>
        public int PoolIndex { get; set; }
        /// <summary>
        /// Staking strategy
        /// </summary>
        public string StakingStrategy { get; set; } = string.Empty;
        /// <summary>
        /// Farm name
        /// </summary>
        public string FarmName { get; set; } = string.Empty;
        /// <summary>
        /// Rewards address
        /// </summary>
        public string RewardAddress { get; set; } = string.Empty;
        /// <summary>
        /// Token address
        /// </summary>
        public string TokenAddress { get; set; } = string.Empty;
        /// <summary>
        /// Is active
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Label
        /// </summary>
        public string Label { get; set; } = string.Empty;
        /// <summary>
        /// App id
        /// </summary>
        public string AppId { get; set; } = string.Empty;
        /// <summary>
        /// Daily ROI
        /// </summary>
        public decimal? DailyROI { get; set; }
        /// <summary>
        /// Weekly ROI
        /// </summary>
        public decimal? WeeklyROI { get; set; }
        /// <summary>
        /// Yearly ROI
        /// </summary>
        public decimal? YearlyROI { get; set; }
        /// <summary>
        /// Lock USD value
        /// </summary>
        public decimal ValueLockedUSD { get; set; }
        /// <summary>
        /// Reward tokens info
        /// </summary>
        public IEnumerable<ZapperRewardToken> RewardTokens { get; set; } = Array.Empty<ZapperRewardToken>();
    }

    /// <summary>
    /// Reward token info
    /// </summary>
    public class ZapperRewardToken
    {
        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// Max amount of decimal places
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
    }
}
