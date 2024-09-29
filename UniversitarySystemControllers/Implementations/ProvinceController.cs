using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Provinces;

namespace UniversitarySystemControllers.Implementations
{
    public class ProvinceController(
        IProvinceOutputPort presenter,
        IProvinceInputPort interactor) : IProvinceController
    {
        public async Task<IEnumerable<ProvinceDTO>> DisplayListProvinces()
        {
            await interactor.GetListProvinces();
            return presenter.Provinces;
        }
    }
}
