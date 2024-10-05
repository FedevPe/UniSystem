using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.UsesCases.BusinessObject.Controllers
{
    public interface ICollegeCareerController
    {
        Task<bool> AddCollegeCareer(CollegeCareerDTO collegeCareer);
        Task<IEnumerable<CollegeCareerDTO>> DisplayListCareers();
    }
}
