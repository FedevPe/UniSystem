using Microsoft.AspNetCore.Mvc;
using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers;

namespace UniversitarySystemControllers.Implementations
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollegeCareerController(
        ICollegeCareerOutputPort outputPort,
        ICollegeCareerInputPort inputPort) : ICollegeCareerController
    {
        [HttpPost]
        public async Task<bool> AddCollegeCareer(CollegeCareerDTO collegeCareer)
        {
            await inputPort.Handle(collegeCareer);
            return outputPort.IsSave;
        }
        [HttpGet]
        public async Task<IEnumerable<CollegeCareerDTO>> DisplayListCareers()
        {
            await inputPort.GetListCareers();
            return outputPort.ListCareers;
        }
    }
}
