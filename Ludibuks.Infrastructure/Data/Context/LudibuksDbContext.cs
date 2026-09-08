using Lubikus.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ludibuks.Infrastructure.Data.Context;

public class LudibuksDbContext : DbContext
{
    public DbSet<Book> Books => Set<Book>(); 
    public DbSet<Author> Authors => Set<Author>();

    public LudibuksDbContext(DbContextOptions<LudibuksDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LudibuksDbContext).Assembly);
    }
}
