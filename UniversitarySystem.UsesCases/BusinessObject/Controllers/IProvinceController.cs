using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.UsesCases.BusinessObject.Controllers
{
    public interface IProvinceController
    {
        Task<IEnumerable<ProvinceDTO>> DisplayListProvinces();
    }
}
