using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.TypeCareers
{
    public interface ITypeCareersOutputPort
    {
        public IEnumerable<TypeCareersDTO> ListTypeCareers { get; }
        Task Handle(IEnumerable<TypeCareersEntity> list);
    }
}
