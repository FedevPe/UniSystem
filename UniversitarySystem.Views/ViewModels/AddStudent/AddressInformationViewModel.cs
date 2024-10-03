using System.Runtime.Loader;
using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;

namespace UniversitarySystem.Views.ViewModels.AddStudent
{
    //Deberia recibir los controladores que sean necesario (Provincias, ciudades)
    public class AddressInformationViewModel 
        (ICityController cityController,
        IProvinceController provinceController)
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public int CityId { get; set; }
        public int ProvinceId { get; set; }

        //Propiedades para almacenar las datos obtenidos del contexto y mostrarlos
        public IEnumerable<ProvinceDTO> ProvincesList { get; set; } = [];
        public IEnumerable<CityDTO> CitiesList { get; set; } = [];

        public async Task ShowListProvinces()
        {
            ProvincesList = await provinceController.DisplayListProvinces();
        }
        public async Task ShowListCities(int provinceId)
        {
            CitiesList = await cityController.DisplayListCitiesByProvinceId(provinceId);
        }

        public static explicit operator AddressDTO(AddressInformationViewModel addressViewModel)
        {
             return new AddressDTO(
                addressViewModel.Id,
                addressViewModel.StudentId,
                addressViewModel.Address,
                addressViewModel.ZipCode,
                addressViewModel.CityId,
                addressViewModel.ProvinceId
             );
            
        }
    }
}
