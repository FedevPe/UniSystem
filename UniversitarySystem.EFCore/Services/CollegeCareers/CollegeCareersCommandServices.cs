using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.CollegeCareers;

namespace UniversitarySystem.EFCore.Services.CollegeCareers
{
    internal class CollegeCareersCommandServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), ICollegeCareersCommandServices
    {
        public async Task AddCollegeCareerAsync(CollegeCareerEntity collegeCareers)
        {
            try
            {
                await AddAsync(collegeCareers);
                await SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Task RemoveCollegeCareerAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task SaveCollegeCareer()
        {
            await SaveChangesAsync();
        }
        public Task UpdateCollegeCareerAsyn(CollegeCareerEntity collegeCareers)
        {
            throw new NotImplementedException();
        }
    }
}
