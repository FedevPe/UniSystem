using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers
{
    public interface ICollegeCareerOutputPort
    {
        public CollegeCareerDTO CollegeCareer { get;}
        public IEnumerable<CollegeCareerDTO> ListCareers { get;}
        Task Handle(CollegeCareerEntity entity);
        Task HandleList(IEnumerable<CollegeCareerEntity> list);
    }
}
