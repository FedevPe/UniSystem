using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.Views.ViewModels.AddStudent
{
    //Deberia recibir los controladores que sean necesario (, )
    public class TitleInformationViewModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string SecondaryDegree { get; set; }
        public string HighSchool { get; set; }
        public DateOnly EgressDate { get; set; }

        public static explicit operator TitleDTO(TitleInformationViewModel viewModel)
        {
            return new TitleDTO(
                viewModel.Id,
                viewModel.StudentId,
                viewModel.SecondaryDegree,
                viewModel.HighSchool,
                viewModel.EgressDate);
        }
    }
}
