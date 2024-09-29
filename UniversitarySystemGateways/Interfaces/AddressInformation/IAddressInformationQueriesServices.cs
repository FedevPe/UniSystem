using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.AddressInformation
{
    public interface IAddressInformationQueriesServices
    {
        Task<AddressEntity> GetAddressInformationByIdAsync(int id);
    }
}
