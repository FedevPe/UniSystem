using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Cities;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemPresenters.Implementations
{
    public class CityPresenter : ICityOutputPort
    {
        public IEnumerable<CityDTO>? Cities { get; private set; }

        public Task HandleList(IEnumerable<CityEntity> cities)
        {
            Cities = cities.Select(c => new CityDTO(c.Id, c.Name, c.ProvinceId));

            return Task.CompletedTask;
        }
    }
}
