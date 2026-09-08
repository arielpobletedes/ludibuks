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

            // 2. Aplicación
            services.AddScoped<IBookAppService, BookAppService>();

            // 3. UI (MVP)
            services.AddTransient<IBookView, FrmBooks>();
            services.AddTransient<BookPresenter>();

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

            // 5. Instanciar formulario y enlazar con su Presenter
            var form = (Form)serviceProvider.GetRequiredService<IBookView>();
            serviceProvider.GetRequiredService<BookPresenter>();

            System.Windows.Forms.Application.Run(form);
        }
    }
}