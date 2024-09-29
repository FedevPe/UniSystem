using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.TitleInformation
{
    public interface ITitleInformationCommandServices
    {
        Task AddTitleInformation(TitleEntity title);
    }
}
