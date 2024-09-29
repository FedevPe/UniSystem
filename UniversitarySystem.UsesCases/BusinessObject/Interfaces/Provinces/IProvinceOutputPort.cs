using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.Provinces
{
    public interface IProvinceOutputPort
    {
        public IEnumerable<ProvinceDTO> Provinces { get; }
        Task HandleListProvinces(IEnumerable<ProvinceEntity> provinces);
    }
}
