using Ludibuks.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Ludibuks.Infrastructure.Data;

public class LudibuksDbContextFactory : IDesignTimeDbContextFactory<LudibuksDbContext>
{
    public LudibuksDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<LudibuksDbContext>();
        optionsBuilder.UseSqlite(DatabasePathHelper.GetConnectionString());

        return new LudibuksDbContext(optionsBuilder.Options);
    }
}
