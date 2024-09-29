using UniversitarySystem.UsesCases.BusinessObject.Repository;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.ProvincesAndCities;

namespace UniversitarySystemGateways.Implementations
{
    public class ProvinceRepository(IProvinceQueryServices queryServices) : IProvinceRepository
    {
        public async Task<IEnumerable<ProvinceEntity>> GetListProvinces()
        {
            return await queryServices.GetProvincesAsync();
        }
    }
}
