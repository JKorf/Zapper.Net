namespace Zapper.Net.Objects.Models
{
    /// <summary>
    /// Base zapper model
    /// </summary>
    public abstract class ZapperModel
    {
        /// <summary>
        /// Error info
        /// </summary>
        public string? Error { get; set; }
    }
}
