using Microsoft.AspNetCore.Mvc;
using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Provinces;

namespace UniversitarySystemControllers.Implementations
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinceController(
        IProvinceOutputPort presenter,
        IProvinceInputPort interactor) : IProvinceController
    {
        [HttpGet]
        public async Task<IEnumerable<ProvinceDTO>> DisplayListProvinces()
        {
            await interactor.GetListProvinces();
            return presenter.Provinces;
        }
    }
}
