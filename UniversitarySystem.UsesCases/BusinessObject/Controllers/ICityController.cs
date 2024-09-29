using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.UsesCases.BusinessObject.Controllers
{
    public interface ICityController
    {
        Task<IEnumerable<CityDTO>> DisplayListCitiesByProvinceId(int provinceId);
    }
}
