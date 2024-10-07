using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.TypeCareers
{
    public interface ITypeCareersOutputPort
    {
        public IEnumerable<TypeCareersDTO> ListTypeCareers { get; }
        public TypeCareersDTO TypeCareer { get; }

        Task HandleList(IEnumerable<TypeCareersEntity> list);
        Task Handle(TypeCareersEntity entity);
    }
}
