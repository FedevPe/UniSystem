using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.TypeCareers;

namespace UniversitarySystemControllers.Implementations
{
    public class TypeCareersController
        (ITypeCareersInputPort interactor,
        ITypeCareersOutputPort presenter)
        : ITypeCareersController
    {
        public async Task<IEnumerable<TypeCareersDTO>> DisplayListTypeCareers()
        {
            await interactor.GetAllTypeCareers();
            return presenter.ListTypeCareers;
        }
    }
}
