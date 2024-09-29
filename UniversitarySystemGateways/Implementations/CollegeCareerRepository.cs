using UniversitarySystem.UsesCases.BusinessObject.Repository;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.CollegeCareers;

namespace UniversitarySystemGateways.Implementations
{
    public class CollegeCareerRepository (
        ICollegeCareersCommandServices commandServices,
        ICollegeCareersQueriesServices queryService): ICollegeCareerRepository
    {
        public async Task AddCollegeCareer(CollegeCareerEntity collegeCareer)
        {
            await commandServices.AddCollegeCareerAsync(collegeCareer);
        }

        public async Task<IEnumerable<CollegeCareerEntity>> GetAllCollegeCareers()
        {
            return await queryService.GetCollegeCareersAsync();
        }

        public async Task SaveChanges()
        {
            await commandServices.SaveCollegeCareer();
        }
    }
}
