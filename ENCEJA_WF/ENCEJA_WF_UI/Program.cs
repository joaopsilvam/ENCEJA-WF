using ENCEJA_WF_Domain.Interfaces.Repositories;
using ENCEJA_WF_Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ENCEJA_WF_UI
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para a aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configura o host genérico para injeção de dependência
            var host = CreateHostBuilder().Build();

            // Resolve e inicia o formulário principal
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var mainForm = services.GetRequiredService<FrmLogin>();
                Application.Run(mainForm);
            }
        }

        /// <summary>
        /// Configura o host genérico e registra os serviços.
        /// </summary>
        /// <returns>IHostBuilder configurado</returns>
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                       .ConfigureAppConfiguration((context, config) =>
                       {
                           config.SetBasePath(AppContext.BaseDirectory);
                           config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                       })
                       .ConfigureServices((context, services) =>
                       {
                           string connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                           services.AddDbContext<ApplicationDbContext>(options =>
                               options.UseSqlServer(connectionString));

                           services.AddTransient<FrmLogin>();
                           services.AddTransient<IUsuarioRepository, UsuarioRepository>();
                       });
        }
    }
}
