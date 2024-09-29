using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.ProvincesAndCities
{
    public interface IProvinceQueryServices
    {
        Task<IEnumerable<ProvinceEntity>> GetProvincesAsync();
    }
}
