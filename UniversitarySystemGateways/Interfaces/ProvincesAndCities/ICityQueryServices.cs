using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.ProvincesAndCities
{
    public interface ICityQueryServices
    {
        Task<IEnumerable<CityEntity>> GetCitiesByProvinceIdAsync(int id);
    }
}
