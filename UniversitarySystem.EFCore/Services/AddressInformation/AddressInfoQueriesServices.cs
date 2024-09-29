using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.AddressInformation;

namespace UniversitarySystem.EFCore.Services.AddressInformation
{
    public class AddressInfoQueriesServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), IAddressInformationQueriesServices
    {
        public async Task<AddressEntity> GetAddressInformationByIdAsync(int id)
        {
            var address = await DetailAddress.FindAsync(id);

            return address;
        }
    }
}
