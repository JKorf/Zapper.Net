using System;
using System.Collections.Generic;
using System.Text;

namespace Zapper.Net.Objects.Models
{
    public class ZapperTokenList
    {
        public IEnumerable<string> Keywords { get; set; }
        public string LogoURI { get; set; }
        public string Name { get; set; }
        public IEnumerable<ZapperToken> Tokens { get; set; }
    }

    public class ZapperToken
    {
        public string Address { get; set; }
        public int ChainId { get; set; }
        public int Decimals { get; set; }
        public string LogoURI { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
