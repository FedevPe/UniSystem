using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemPresenters.Implementations
{
    public class CollegeCareerPresenter : ICollegeCareerOutputPort
    {
        public IEnumerable<CollegeCareerDTO>? ListCareers { get; private set; }
        public CollegeCareerDTO? CollegeCareer { get ; private set; }

        public Task HandleList(IEnumerable<CollegeCareerEntity> list)
        {
            ListCareers = list.Select(x => new CollegeCareerDTO(
                                            x.IdCollegeCareer,
                                            x.CollegeCareer,
                                            x.Description,
                                            x.Duration,
                                            x.TypeId)).ToList();
            return Task.CompletedTask;
        }
        public Task Handle(CollegeCareerEntity entity)
        { 
            CollegeCareer = new CollegeCareerDTO(
                entity.IdCollegeCareer,
                entity.CollegeCareer,
                entity.Description,
                entity.Duration,
                entity.TypeId);

            return Task.CompletedTask;
        }
    }
}
