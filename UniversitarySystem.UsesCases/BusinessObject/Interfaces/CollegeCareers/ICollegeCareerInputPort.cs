using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers
{
    public interface ICollegeCareerInputPort
    {
        Task Handle(CollegeCareerDTO collegeCareers);
        Task GetListCareers();
    }
}
