using UniversitarySystem.Views.ViewModels.AddCollegeCareer;
using UniversitarySystem.Views.ViewModels.AddStudent;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddViewsServices(this IServiceCollection services)
        {
            services.AddTransient<AddStudentFormViewModel>()
                    .AddTransient<AddressInformationViewModel>()
                    .AddTransient<PersonalInformationViewModel>()
                    .AddTransient<TitleInformationViewModel>()
                    .AddTransient<AddCareerFormViewModel>()
                    .AddTransient<CollegeCareerViewModel>();

            return services;
        }
    }
}
