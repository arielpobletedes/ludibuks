using Microsoft.EntityFrameworkCore;
using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Application.Interfaces;
using Ludibuks.Application.Services;
using Ludibuks.Infrastructure.Data;
using Ludibuks.Infrastructure.Data.Context;
using Ludibuks.Infrastructure.Repositories;
using Ludibuks.WinUI.Presenters;
using Ludibuks.WinUI.Views.Forms;
using Ludibuks.WinUI.Views.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Ludibuks.WinUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // 1. Infraestructura / Base de Datos
            services.AddDbContext<LudibuksDbContext>(options =>
                options.UseSqlite(DatabasePathHelper.GetConnectionString()));
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();

            // 2. Aplicación
            services.AddScoped<IBookAppService, BookAppService>();
            services.AddScoped<IAuthorAppService, AuthorAppService>();

            // 3. UI (MVP)
            services.AddSingleton<FrmBooks>();
            services.AddSingleton<IBookView>(sp => sp.GetRequiredService<FrmBooks>());
            services.AddSingleton<BookPresenter>();

            using var serviceProvider = services.BuildServiceProvider();

            // 4. Migración automática de SQLite al arrancar
            try
            {
                await DatabaseInitializer.ApplyMigrationsAsync(serviceProvider);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar la base de datos:\n{ex.Message}",
                                "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Resolver el Presenter primero (instancia FrmBooks y conecta los eventos), luego obtener el mismo Form para ejecutarlo
            var presenter = serviceProvider.GetRequiredService<BookPresenter>();
            var form = serviceProvider.GetRequiredService<FrmBooks>();

            System.Windows.Forms.Application.Run(form);
        }
    }
}