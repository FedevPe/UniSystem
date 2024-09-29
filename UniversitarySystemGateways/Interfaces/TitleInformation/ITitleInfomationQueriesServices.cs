using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.TitleInformation
{
    public interface ITitleInfomationQueriesServices
    {
        Task<TitleEntity> GetTitleInfoById(int id);
    }
}
