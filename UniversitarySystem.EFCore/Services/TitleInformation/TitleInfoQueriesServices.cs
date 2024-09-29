using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.TitleInformation;

namespace UniversitarySystem.EFCore.Services.TitleInformation
{
    internal class TitleInfoQueriesServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), ITitleInfomationQueriesServices
    {
        public async Task<TitleEntity> GetTitleInfoById(int id)
        {
            var title = await Titles.FindAsync(id);

            return title;
        }
    }
}
