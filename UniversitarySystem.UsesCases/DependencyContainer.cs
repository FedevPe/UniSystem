using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Cities;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Provinces;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.TypeCareers;
using UniversitarySystem.UsesCases.Interactors;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesInteractors(this IServiceCollection services)
        {
            services.AddSingleton<IStudentInputPort, StudentInteractor>()
                    .AddSingleton<ICollegeCareerInputPort, CollegeCareerInteractor>()
                    .AddSingleton<IProvinceInputPort, ProvinceInteractor>()
                    .AddSingleton<ICityInputPort, CityInteractor>()
                    .AddSingleton<ITypeCareersInputPort, TypeCareersInteractor>();

            return services;
        }
    }

}
