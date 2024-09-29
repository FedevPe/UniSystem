using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.BloodType
{
    public interface IBloodTypeQueriesServices
    {
        Task<IEnumerable<BloodTypeEntity>> GetBloodTypesAsync();
        Task<BloodTypeEntity> GetBloodTypeById(int id);
    }
}
