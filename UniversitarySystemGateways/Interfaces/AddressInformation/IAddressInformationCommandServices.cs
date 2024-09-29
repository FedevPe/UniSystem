using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.AddressInformation
{
    public interface IAddressInformationCommandServices
    {
        Task AddAddresInformationAsyn(AddressEntity address);
    }
}
