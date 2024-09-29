using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.Cities
{
    public interface ICityOutputPort
    {
        public IEnumerable<CityDTO> Cities { get; }
        Task HandleList(IEnumerable<CityEntity> cities);
    }
}
