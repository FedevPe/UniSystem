using Microsoft.AspNetCore.Mvc;
using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.TypeCareers;

namespace UniversitarySystemControllers.Implementations
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypeCareersController
        (ITypeCareersInputPort interactor,
        ITypeCareersOutputPort presenter)
        : ITypeCareersController
    {
        [HttpGet]
        public async Task<IEnumerable<TypeCareersDTO>> GetListTypeCareers()
        {
            await interactor.GetAllTypeCareers();
            return presenter.ListTypeCareers;
        }
        [HttpGet]
        public async Task<TypeCareersDTO> GetTypeCareersById(int id)
        {
            await interactor.GetTypeCareersById(id);
            return presenter.TypeCareer;
        }
    }
}
