using UniversitarySystem.EFCore.Options;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesDependencyContainer
    {
        public static IServiceCollection AddDBContextServices(
            this IServiceCollection services,
            Action<DBOption> configureDBOptions)
        {
            services.AddServicesInteractors()
                .AddServicesControllers()
                .AddServicesRepositories()
                .AddServicesPresenters()
                .AddViewsServices()
                .AddContextServices(configureDBOptions);

            return services;
        }

    }
}
