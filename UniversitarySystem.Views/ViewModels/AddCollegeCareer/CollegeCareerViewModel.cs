using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;

namespace UniversitarySystem.Views.ViewModels.AddCollegeCareer
{
    public class CollegeCareerViewModel 
        (ICollegeCareerController careerController,
        ITypeCareersController typeController)
    {
        public string NameCareerSearch { get; set; } = "";
        public string DurationCareer { get; set; }
        public int IdTypeSelected { get; set; }


        public IEnumerable<CollegeCareerDTO> ListCollegeCareers { get; set; } = [];
        public IEnumerable<TypeCareersDTO> ListTypesCareer { get; set; } = [];

        public async Task DisplayListCollegeCareers()
        {
            ListCollegeCareers = await careerController.DisplayListCareers();
        }
        public async Task DisplayListTypesCareer()
        {
            ListTypesCareer = await typeController.GetListTypeCareers();
        }
    }
}
