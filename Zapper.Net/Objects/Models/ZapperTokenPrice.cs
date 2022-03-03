namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// Token price
    /// </summary>
    public class ZapperTokenPrice
    {
        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// Max amount of decimals
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
