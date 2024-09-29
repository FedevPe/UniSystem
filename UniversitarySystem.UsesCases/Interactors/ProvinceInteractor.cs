using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Provinces;
using UniversitarySystem.UsesCases.BusinessObject.Repository;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.Interactors
{
    public class ProvinceInteractor (
        IProvinceOutputPort presenter,
        IProvinceRepository repository) : IProvinceInputPort
    {
        public async Task GetListProvinces()
        {
            await presenter.HandleListProvinces(await repository.GetListProvinces());
        }
    }
}
