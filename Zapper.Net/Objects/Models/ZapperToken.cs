using System;
using System.Collections.Generic;

namespace Zapper.Net.Objects.Models
{
    internal class ZapperTokenList
    {
        public IEnumerable<string> Keywords { get; set; } = Array.Empty<string>();
        public string LogoURI { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public IEnumerable<ZapperToken> Tokens { get; set; } = Array.Empty<ZapperToken>();
    }

    /// <summary>
    /// Token info
    /// </summary>
    public class ZapperToken
    {
        /// <summary>
        /// Token address
        /// </summary>
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// Chain id
        /// </summary>
        public int ChainId { get; set; }
        /// <summary>
        /// Max amount of decimals
        /// </summary>
        public int Decimals { get; set; }
        /// <summary>
        /// Logo URI
        /// </summary>
        public string LogoURI { get; set; } = string.Empty;
        /// <summary>
        /// Token name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Token symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
    }
}
