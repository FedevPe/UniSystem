using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.ProvincesAndCities;

namespace UniversitarySystem.EFCore.Services.ProvincesAndCities
{
    public class ProvinceQueryServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), IProvinceQueryServices
    {
        public async Task<IEnumerable<ProvinceEntity>> GetProvincesAsync()
        { 
            return await Provinces.ToListAsync();
        }
    }
}
