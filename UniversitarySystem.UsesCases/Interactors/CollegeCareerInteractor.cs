using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers;
using UniversitarySystem.UsesCases.BusinessObject.Repository;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.Interactors
{
    public class CollegeCareerInteractor(
        ICollegeCareerOutputPort outputPort,
        ICollegeCareerRepository repository) : ICollegeCareerInputPort
    {
        public async Task Handle(CollegeCareerDTO collegeCareer)
        {
            var entity = new CollegeCareerEntity
            {
                CollegeCareer = collegeCareer.Name,
                Description = collegeCareer.Description,
                Duration = collegeCareer.Duration,
                TypeCareersId = collegeCareer.TypeId
            };

            await repository.AddCollegeCareer(entity);
            await repository.SaveChanges();

            // Podrías llamar al OutputPort si necesitas pasar algún dato a la UI
            await outputPort.Handle(entity);
        }
        public async Task GetListCareers()
        {
            await outputPort.HandleList(await repository.GetAllCollegeCareers());
        }
    }
}
