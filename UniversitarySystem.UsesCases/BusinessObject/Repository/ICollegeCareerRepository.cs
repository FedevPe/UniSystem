using UniversitarySystem.Entities.Interfaces;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.BusinessObject.Repository
{
    public interface ICollegeCareerRepository : IUnitOfWork
    {
        Task<IEnumerable<CollegeCareerEntity>> GetAllCollegeCareers();
        Task AddCollegeCareer(CollegeCareerEntity collegeCareer);
    }
}
