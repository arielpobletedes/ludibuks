using Lubikus.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ludibuks.Infrastructure.Data.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Title).IsRequired().HasMaxLength(200);
        builder.Property(b => b.Isbn).IsRequired().HasMaxLength(20);
        builder.Property(b => b.Price).HasPrecision(18, 2);
    }
}
