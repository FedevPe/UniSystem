using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.TitleInformation;

namespace UniversitarySystem.EFCore.Services.TitleInformation
{
    public class TitleInfoCommandServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options),
        ITitleInformationCommandServices
    {
        public async Task AddTitleInformation(TitleEntity title)
        {
            await AddAsync(title);

            await SaveChangesAsync();
        }
    }
}
