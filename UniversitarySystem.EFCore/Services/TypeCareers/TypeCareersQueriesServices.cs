using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.TypeCareers;

namespace UniversitarySystem.EFCore.Services.TypeCareers
{
    public class TypeCareersQueriesServices(IOptions<DBOption> option)
        : UniversitarySystemContext(option),
        ITypeCareersQueriesServices
    {
        public async Task<IEnumerable<TypeCareersEntity>> GetListTypeCareers()
        {
            return await TypeCareers.ToListAsync();
        }

        public async Task<TypeCareersEntity> GetTypeById(int id)
        {
            return await TypeCareers.FindAsync(id);
        }
    }
}
