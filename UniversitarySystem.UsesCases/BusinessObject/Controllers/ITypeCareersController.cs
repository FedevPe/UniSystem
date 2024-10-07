using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.UsesCases.BusinessObject.Controllers
{
    public interface ITypeCareersController
    {
        Task<IEnumerable<TypeCareersDTO>> GetListTypeCareers();
        Task<TypeCareersDTO> GetTypeCareersById(int id);
    }
}
