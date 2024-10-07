using UniversitarySystem.Views.ViewModels.CollegeCareer;
using UniversitarySystem.Views.ViewModels.Student.AddStudent;

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
