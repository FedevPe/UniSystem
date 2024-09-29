using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.UsesCases.BusinessObject.Controllers
{
    public interface ICollegeCareerController
    {
        Task AddCollegeCareer(CollegeCareerDTO collegeCareer);
        Task<IEnumerable<CollegeCareerDTO>> DisplayListCareers();
    }
}
