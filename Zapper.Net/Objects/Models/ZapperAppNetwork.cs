using System;
using System.Collections.Generic;

namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// App network
    /// </summary>
    public class ZapperAppNetwork
    {
        /// <summary>
        /// Network name
        /// </summary>
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// Actions
        /// </summary>
        public IEnumerable<string> Actions { get; set; } = Array.Empty<string>();
    }
}
