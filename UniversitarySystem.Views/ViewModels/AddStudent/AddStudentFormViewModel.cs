using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;

namespace UniversitarySystem.Views.ViewModels.AddStudent
{
    //Deberia utilizar los controladores que sean necesario
    public class AddStudentFormViewModel(IStudentController controller)
    {
        public PersonalInformationViewModel PersonalInformation { get; set; }
        public AddressInformationViewModel AddressInformation { get; set; }
        public TitleInformationViewModel TitleInformation { get; set; }

        public async Task Send()
        {
            var result = await controller.AddStudent((StudentDTO)this);
        }
        public static explicit operator StudentDTO(AddStudentFormViewModel model)
        {
            return new StudentDTO(
                model.PersonalInformation.Id,
                model.PersonalInformation.FirstName,
                model.PersonalInformation.LastName,
                model.PersonalInformation.DNI,
                model.PersonalInformation.CUIL,
                model.PersonalInformation.DateOfBirth,
                model.PersonalInformation.NumberPhone,
                model.PersonalInformation.Email,
                model.PersonalInformation.DateRegistry,
                (TitleDTO)model.TitleInformation,
                (AddressDTO)model.AddressInformation);
        }
    }
}
