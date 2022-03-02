using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Zapper.Net.Objects.Internal
{
    public class ZapperResultWrapper<T>
    {
        [JsonProperty("error")]
        public IEnumerable<string> Errors { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}
