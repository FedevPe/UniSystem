namespace UniversitarySystem.Views.Pages
{
    public partial class CollegeCareers
    {
        private bool IsCollapse = true;
        private string classFiltersButton = "fa-solid fa-angle-down";
        protected override async Task OnInitializedAsync()
        {
            await viewModel.DisplayListCollegeCareers();
            await viewModel.DisplayListTypesCareer();
        }
        private async Task FindTypeCareer(int id)
        {
            await viewModel.GetTypeCareerById(id);
        }
        private void ToggleCollapse()
        {
            IsCollapse = !IsCollapse;

            if (IsCollapse)
            {
                classFiltersButton = "fa-solid fa-angle-down";
            }
            else
            {
                classFiltersButton = "fa-solid fa-angle-up";
            }
        }
    }
}