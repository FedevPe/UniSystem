using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers;

namespace UniversitarySystemControllers.Implementations
{
    public class CollegeCareerController(
        ICollegeCareerOutputPort outputPort,
        ICollegeCareerInputPort inputPort) : ICollegeCareerController
    {
        
        public async Task AddCollegeCareer(CollegeCareerDTO collegeCareer)
        {
            await inputPort.Handle(collegeCareer);
        }

        public async Task<IEnumerable<CollegeCareerDTO>> DisplayListCareers()
        {
            await inputPort.GetListCareers();
            return outputPort.ListCareers;
        }
    }
}
