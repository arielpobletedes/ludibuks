using Ludibuks.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ludibuks.Infrastructure.Data;

public static class DatabaseInitializer
{
    public static async Task ApplyMigrationsAsync(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<LudibuksDbContext>();
        await context.Database.MigrateAsync();
    }
}