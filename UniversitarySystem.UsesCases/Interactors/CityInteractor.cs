using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Cities;
using UniversitarySystem.UsesCases.BusinessObject.Repository;

namespace UniversitarySystem.UsesCases.Interactors
{
    public class CityInteractor
        (ICityOutputPort presenter,
        ICityRepository repository) : ICityInputPort
    {
        public async Task GetListCitiesByProvinceId(int provinceId)
        {
            await presenter.HandleList(await repository.GetListCitiesByProvinceId(provinceId));
        }
    }
}
