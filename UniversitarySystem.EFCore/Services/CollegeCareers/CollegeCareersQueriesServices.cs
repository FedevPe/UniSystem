using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.CollegeCareers;

namespace UniversitarySystem.EFCore.Services.CollegeCareers
{
    internal class CollegeCareersQueriesServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), ICollegeCareersQueriesServices
    {
        public async Task<CollegeCareerEntity> GetByIdCollegeCareerAsync(int id)
        {
            return await CollegeCareers.FindAsync(id);
        }

        public async Task<IEnumerable<CollegeCareerEntity>> GetCollegeCareersAsync()
        {
            return await CollegeCareers.ToListAsync(); 
        }
    }
}
