using UniversitarySystem.EFCore.Options;
using UniversitarySystem.EFCore.Services.AddressInformation;
using UniversitarySystem.EFCore.Services.BloodType;
using UniversitarySystem.EFCore.Services.CollegeCareers;
using UniversitarySystem.EFCore.Services.ProvincesAndCities;
using UniversitarySystem.EFCore.Services.Students;
using UniversitarySystem.EFCore.Services.TitleInformation;
using UniversitarySystem.EFCore.Services.TypeCareers;
using UniversitarySystemGateways.Interfaces.AddressInformation;
using UniversitarySystemGateways.Interfaces.BloodType;
using UniversitarySystemGateways.Interfaces.CollegeCareers;
using UniversitarySystemGateways.Interfaces.ProvincesAndCities;
using UniversitarySystemGateways.Interfaces.Student;
using UniversitarySystemGateways.Interfaces.TitleInformation;
using UniversitarySystemGateways.Interfaces.TypeCareers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddContextServices(this IServiceCollection services,
            Action<DBOption> configureDBOptions)
        {
            services.Configure(configureDBOptions);

            services.AddTransient<IAddressInformationCommandServices, AddressInfoCommandServices>()
                    .AddTransient<IAddressInformationQueriesServices, AddressInfoQueriesServices>()

                    .AddTransient<IBloodTypeQueriesServices, BloodTypeQueriesServices>()

                    .AddTransient<ICollegeCareersCommandServices, CollegeCareersCommandServices>()
                    .AddTransient<ICollegeCareersQueriesServices, CollegeCareersQueriesServices>()

                    .AddTransient<ICityQueryServices, CityQueryServices>()
                    .AddTransient<IProvinceQueryServices, ProvinceQueryServices>()

                    .AddTransient<IStudentCommandServices, StudentCommandServices>()
                    .AddTransient<IStudentQueryServices, StudentQuerysServices>()

                    .AddTransient<ITitleInformationCommandServices, TitleInfoCommandServices>()
                    .AddTransient<ITitleInfomationQueriesServices, TitleInfoQueriesServices>()

                    .AddTransient<ITypeCareersQueriesServices, TypeCareersQueriesServices>();

            return services;
        }
    }
}
