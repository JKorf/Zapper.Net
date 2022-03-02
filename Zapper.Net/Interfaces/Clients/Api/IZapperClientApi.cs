namespace Zapper.Net.Interfaces.Clients.Api
{
    /// <summary>
    /// Zapper API endpoints
    /// </summary>
    public interface IZapperClientApi
    {
        /// <summary>
        /// Endpoints related to a specific address
        /// </summary>
        public IZapperClientApiAddressData AddressData { get; }

        /// <summary>
        /// General data endpoints
        /// </summary>
        public IZapperClientApiGeneralData GeneralData { get; }
    }
}
