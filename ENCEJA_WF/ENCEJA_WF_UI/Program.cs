using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Windows.Forms;
using ENCEJA_WF_Infrastructure;

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
                var mainForm = services.GetRequiredService<Form1>();
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
                           // Carregar configurações do appsettings.json
                           config.SetBasePath(AppContext.BaseDirectory);
                           config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                       })
                       .ConfigureServices((context, services) =>
                       {
                           // Obtém a string de conexão do appsettings.json
                           string connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                           var databasePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, connectionString.Replace("Data Source=", "").Trim()));
                           Console.WriteLine($"Caminho do banco de dados: {databasePath}");
                           // Verifica o caminho absoluto do banco de dados
                           Console.WriteLine($"Caminho do banco de dados: {databasePath}");

                           // Cria o diretório se não existir
                           var databaseDirectory = Path.GetDirectoryName(databasePath);
                           if (!Directory.Exists(databaseDirectory))
                           {
                               Directory.CreateDirectory(databaseDirectory);
                               Console.WriteLine($"Diretório criado: {databaseDirectory}");
                           }

                           // Adiciona o DbContext com a string de conexão do appsettings.json
                           services.AddDbContext<ENCEJA_WFDbContext>(options =>
                               options.UseSqlite(connectionString));

                           // Registra o Form1 como Transient (não pode ser Singleton)
                           services.AddTransient<Form1>();

                           // Registra outros serviços necessários
                           // Exemplo: services.AddScoped<IAlunoRepository, AlunoRepository>();
                       });
        }
    }
}