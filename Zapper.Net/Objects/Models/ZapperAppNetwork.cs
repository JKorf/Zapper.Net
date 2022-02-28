using System;
using System.Collections.Generic;
using System.Text;

namespace Zapper.Net.Objects.Models
{
    public class ZapperAppNetwork
    {
        public string Network { get; set; }
        public IEnumerable<string> Actions { get; set; }
    }
}
