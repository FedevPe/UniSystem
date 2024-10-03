using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystemControllers.Implementations;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainerController
{
    public static IServiceCollection AddServicesControllers(this IServiceCollection services)
    {
        services.AddSingleton<ICityController, CityController>()
                .AddSingleton<ICollegeCareerController, CollegeCareerController>()
                .AddSingleton<IProvinceController, ProvinceController>()
                .AddSingleton<IStudentController, StudentController>()
                .AddSingleton<ITypeCareersController, TypeCareersController>();

        return services;
    }
}
