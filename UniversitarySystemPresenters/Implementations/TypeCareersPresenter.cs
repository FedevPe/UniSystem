using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.TypeCareers;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemPresenters.Implementations
{
    public class TypeCareersPresenter : ITypeCareersOutputPort
    {
        public IEnumerable<TypeCareersDTO>? ListTypeCareers { get; private set; }

        public Task Handle(IEnumerable<TypeCareersEntity> list)
        {
            ListTypeCareers = list.Select(x => new TypeCareersDTO(x.Id, x.Type)).ToList();
            return Task.CompletedTask;
        }
    }
}
