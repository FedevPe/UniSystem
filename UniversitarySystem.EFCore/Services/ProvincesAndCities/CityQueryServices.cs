using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.ProvincesAndCities;

namespace UniversitarySystem.EFCore.Services.ProvincesAndCities
{
    public class CityQueryServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), ICityQueryServices
    {
        public async Task<IEnumerable<CityEntity>> GetCitiesByProvinceIdAsync(int filterId)
        {
            return await Cities.Where(c => (c.ProvinceId == filterId)).ToListAsync();
        }
    }
}
