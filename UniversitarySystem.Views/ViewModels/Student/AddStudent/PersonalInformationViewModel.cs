using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;

namespace UniversitarySystem.Views.ViewModels.Student.AddStudent
{
    public class PersonalInformationViewModel(ICollegeCareerController careerController)
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public string CUIL { get; set; }
        public DateOnly DateOfBirth { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public DateOnly DateRegistry { get; set; } = DateOnly.FromDateTime(DateTime.Now);


        //Propiedad para guarda el id de la carrera al que el estudiante se inscribe
        public int IdCollegeCareer { get; set; }
        public IEnumerable<CollegeCareerDTO> CollegeCareer { get; set; } = [];

        public async Task ListCollegeCareers()
        {
            CollegeCareer = await careerController.DisplayListCareers();
        }

    }
}
