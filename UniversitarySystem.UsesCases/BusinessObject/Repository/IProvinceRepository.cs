using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.BusinessObject.Repository
{
    public interface IProvinceRepository
    {
        Task<IEnumerable<ProvinceEntity>> GetListProvinces();
    }
}
