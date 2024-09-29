using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UI.WinForms.Extensions;

namespace UniversitarySystem.UI.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ConfigureApplication();

            var services = ConfigureServices();

            var servicesProvider = services.BuildServiceProvider();

            Application.Run(new MainFrame(servicesProvider));
        }
        private static void ConfigureApplication()
        {
            ApplicationConfiguration.Initialize();
        }

        private static IServiceCollection ConfigureServices()
        {            
            var services = new ServiceCollection();
            
            //reloadOnChange = se actualiza en caso de que cambie, mientras la aplicaci�n se
            //esta ejecutando
            var configuration = new ConfigurationBuilder()
                //Este metodo define la direcci�n en la que se buscar�n de los archivos de configuraci�n.
                //AppContext.BaseDirectory = es una propiedad de .NET que retorna la ruta del directorio base
                //donde se ejecuta la aplicaci�n. Por ejemplo: C:\Projects\MyApp\bin\Debug\net6.0\
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            
            services.AddWindowsFormsBlazorWebView();
            services.AddBlazorWebViewDeveloperTools();

            //Esta configuraci�n se instancia durante el ciclo de vida de la aplicaci�n y
            //ser� compartida por todos los componentes que la necesiten
            services.AddSingleton<IConfiguration>(configuration);

            services.AddDatabaseServices(configuration);

            return services;
        }
    }
}