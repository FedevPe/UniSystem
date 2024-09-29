using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.BusinessObject.Repository
{
    public interface ICityRepository
    {
        Task<IEnumerable<CityEntity>> GetListCitiesByProvinceId(int id);
    }
}
