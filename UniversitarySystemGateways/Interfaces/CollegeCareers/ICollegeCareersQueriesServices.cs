using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.CollegeCareers
{
    public interface ICollegeCareersQueriesServices
    {
        Task<IEnumerable<CollegeCareerEntity>> GetCollegeCareersAsync();
        Task<CollegeCareerEntity> GetByIdCollegeCareerAsync(int id);
    }
}
