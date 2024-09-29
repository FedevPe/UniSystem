using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.AddressInformation;

namespace UniversitarySystem.EFCore.Services.AddressInformation
{
    public class AddressInfoCommandServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), IAddressInformationCommandServices
    {
        public async Task AddAddresInformationAsyn(AddressEntity address)
        {
            await AddAsync(address);

            await SaveChangesAsync();
        }
    }
}
