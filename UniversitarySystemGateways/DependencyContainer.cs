using UniversitarySystem.UsesCases.BusinessObject.Repository;
using UniversitarySystemGateways.Implementations;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesRepositories(this IServiceCollection services)
        {
            services.AddSingleton<ICityRepository, CityRepository>()
                    .AddSingleton<ICollegeCareerRepository, CollegeCareerRepository>()
                    .AddSingleton<IProvinceRepository, ProvinceRepository>()
                    .AddSingleton<IStudentRepository, StudentRepository>();

            return services;
        }
    }
}
