using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Cities;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.CollegeCareers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Provinces;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student;
using UniversitarySystemPresenters.Implementations;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddServicesPresenters(this IServiceCollection services)
    {
        services.AddSingleton<ICityOutputPort, CityPresenter>()
                .AddSingleton<ICollegeCareerOutputPort, CollegeCareerPresenter>()
                .AddSingleton<IProvinceOutputPort, ProvincePresenter>()
                .AddSingleton<IStudentOutputPort, StudentPresenter>();

        return services;
    }
}
