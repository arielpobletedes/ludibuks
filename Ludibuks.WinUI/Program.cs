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
            services.AddScoped<IGenreRepository, GenreRepository>();

            // 2. Aplicación
            services.AddScoped<IBookAppService, BookAppService>();
            services.AddScoped<IAuthorAppService, AuthorAppService>();
            services.AddScoped<IGenreAppService, GenreAppService>();

            // 3. UI (MVP)
            services.AddSingleton<FrmBooks>();
            services.AddSingleton<IBookView>(sp => sp.GetRequiredService<FrmBooks>());
            services.AddSingleton<BookPresenter>();

            services.AddSingleton<FrmMain>();
            services.AddSingleton<IMainView>(sp => sp.GetRequiredService<FrmMain>());
            services.AddSingleton<MainPresenter>();

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

            // 5. Inicializar Presenters y ejecutar la ventana principal FrmMain
            serviceProvider.GetRequiredService<BookPresenter>();
            serviceProvider.GetRequiredService<MainPresenter>();
            var mainForm = serviceProvider.GetRequiredService<FrmMain>();

            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}