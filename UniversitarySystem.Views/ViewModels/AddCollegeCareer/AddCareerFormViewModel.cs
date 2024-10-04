using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;

namespace UniversitarySystem.Views.ViewModels.AddCollegeCareer
{
    public class AddCareerFormViewModel(
        ICollegeCareerController controller,
        ITypeCareersController typeCareerController)
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int TypeId { get; set; }

        public IEnumerable<TypeCareersDTO> TypesCareers { get; set; }

        public async Task DisplayTypeCareers()
        {
            TypesCareers = await typeCareerController.GetListTypeCareers();
        }
        public async Task SaveCollegeCareer()
        {
            await controller.AddCollegeCareer((CollegeCareerDTO)this);
        }

        public static explicit operator CollegeCareerDTO(AddCareerFormViewModel viewModel)
        {
            return new CollegeCareerDTO
                (
                    viewModel.Id,
                    viewModel.Name,
                    viewModel.Description,
                    viewModel.Duration,
                    viewModel.TypeId
                );
        }
    }
}
