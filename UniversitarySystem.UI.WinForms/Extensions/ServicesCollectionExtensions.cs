using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UniversitarySystem.EFCore.Options;

namespace UniversitarySystem.UI.WinForms.Extensions;

public static class ServicesCollectionExtensions
{
    public static IServiceCollection AddDatabaseServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddServices(options =>
        {
            configuration.GetSection(DBOption.SectionKey).Bind(options);
        });

        return services;  
    }
}
