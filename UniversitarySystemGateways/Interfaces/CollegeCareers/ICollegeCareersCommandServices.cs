using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.CollegeCareers
{
    public interface ICollegeCareersCommandServices
    {
        Task AddCollegeCareerAsync(CollegeCareerEntity collegeCareers);
        Task RemoveCollegeCareerAsync(int id);
        Task UpdateCollegeCareerAsyn(CollegeCareerEntity collegeCareers);


        //Tarea para delegar la responsabilidad al servicio
        Task SaveCollegeCareer();
    }
}
