using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.BusinessObject.Repository
{
    public interface ITypeCareersRepository
    {
        Task<IEnumerable<TypeCareersEntity>> GetListTypeCareers();
        Task<TypeCareersEntity> GetTypeById(int id);
    }
}
