using UniversitarySystem.UsesCases.BusinessObject.Repository;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.TypeCareers;

namespace UniversitarySystemGateways.Implementations
{
    public class TypeCareersRepository
        (ITypeCareersQueriesServices services) : ITypeCareersRepository
    {
        public async Task<IEnumerable<TypeCareersEntity>> GetListTypeCareers()
        {
            return await services.GetListTypeCareers();
        }
    }
}
