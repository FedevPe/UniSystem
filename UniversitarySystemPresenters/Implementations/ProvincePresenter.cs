using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Provinces;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemPresenters.Implementations
{
    public class ProvincePresenter : IProvinceOutputPort
    {
        public IEnumerable<ProvinceDTO>? Provinces { get; private set; }

        public Task HandleListProvinces(IEnumerable<ProvinceEntity> listProvinces)
        {
            Provinces = listProvinces.Select(p => new ProvinceDTO(p.Id, p.Name)).ToList();

            return Task.CompletedTask;
        }
    }
}
