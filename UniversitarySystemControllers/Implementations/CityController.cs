using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Cities;

namespace UniversitarySystemControllers.Implementations
{
    public class CityController
        (ICityInputPort interactor,
        ICityOutputPort presenter) : ICityController
    {
        public async Task<IEnumerable<CityDTO>> DisplayListCitiesByProvinceId(int provinceId)
        {
            await interactor.GetListCitiesByProvinceId(provinceId);
            return presenter.Cities;
        }
    }
}
