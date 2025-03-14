using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace SVPresentation
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Crear el host y ejecutar la aplicación
            var host = CreateHostBuilder(args).Build();
            
            // Ejecutar el formulario principal de la aplicación
            Application.Run(new Form1());
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                });
    }
}
