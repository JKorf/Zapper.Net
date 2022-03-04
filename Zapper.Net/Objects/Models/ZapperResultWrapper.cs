using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// Result wrapper
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ZapperResultWrapper<T>
    {
        /// <summary>
        /// Errors
        /// </summary>
        [JsonProperty("error")]
        public IEnumerable<string> Errors { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Data
        /// </summary>
        public IEnumerable<T> Data { get; set; } = Array.Empty<T>();
    }
}
