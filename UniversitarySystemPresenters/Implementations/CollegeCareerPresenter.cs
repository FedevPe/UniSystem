using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemPresenters.Implementations
{
    public class CollegeCareerPresenter : ICollegeCareerOutputPort
    {
        public List<CollegeCareerDTO>? ListCareers { get; private set; }
        public CollegeCareerDTO? CollegeCareer { get; private set; }

        public bool IsSaved { get; private set; } = false;

        public Task HandleList(IEnumerable<CollegeCareerEntity> list)
        {
            ListCareers = list.Select(x => new CollegeCareerDTO(
              x.IdCollegeCareer, x.CollegeCareer, x.Description,
              x.Duration, x.TypeCareersId, x.Mode, x.Status,
              new TypeCareersDTO(x.TypeCareers.Id, x.TypeCareers.Type))).ToList();

            return Task.CompletedTask;
        }
        public Task Handle(CollegeCareerEntity entity)
        {
            if (entity.IdCollegeCareer != 0)
            {
                IsSaved = true;
            }
            return Task.CompletedTask;
        }
    }
}
