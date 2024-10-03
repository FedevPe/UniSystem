using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.TypeCareers
{
    public interface ITypeCareersQueriesServices
    {
        Task<IEnumerable<TypeCareersEntity>> GetListTypeCareers();
    }
}
