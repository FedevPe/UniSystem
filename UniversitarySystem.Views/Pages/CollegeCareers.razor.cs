namespace UniversitarySystem.Views.Pages
{
    public partial class CollegeCareers
    {
        protected override async Task OnInitializedAsync()
        {
            await ViewModel.DisplayListCollegeCareers();
            await ViewModel.DisplayListTypesCareer();
        }
        //private async Task FindTypeCareer(int id)
        //{
        //    await viewModel.GetTypeCareerById(id);
        //}
    }
}