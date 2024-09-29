using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.BloodType;

namespace UniversitarySystem.EFCore.Services.BloodType
{
    public class BloodTypeQueriesServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), IBloodTypeQueriesServices
    {
        public async Task<BloodTypeEntity> GetBloodTypeById(int id)
        {
            return await BloodTypes.FindAsync(id);
        }

        public async Task<IEnumerable<BloodTypeEntity>> GetBloodTypesAsync()
        {
            return await BloodTypes.ToListAsync();
        }
    }
}
