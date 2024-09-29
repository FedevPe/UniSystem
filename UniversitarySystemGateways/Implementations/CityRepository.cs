using UniversitarySystem.UsesCases.BusinessObject.Repository;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.ProvincesAndCities;

namespace UniversitarySystemGateways.Implementations
{
    public class CityRepository(ICityQueryServices queriesServices) : ICityRepository
    {
        public async Task<IEnumerable<CityEntity>> GetListCitiesByProvinceId(int id)
        {
            return await queriesServices.GetCitiesByProvinceIdAsync(id);
        }
    }
}
