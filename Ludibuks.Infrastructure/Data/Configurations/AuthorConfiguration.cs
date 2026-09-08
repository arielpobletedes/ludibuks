using Lubikus.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ludibuks.Infrastructure.Data.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(a => a.Biography)
            .HasMaxLength(1000);

        // Mapeo explícito de la relación Many-to-Many con claves foráneas principales
        builder.HasMany(a => a.Books)
            .WithMany(b => b.Authors)
            .UsingEntity<Dictionary<string, object>>(
                "BookAuthor",
                j => j.HasOne<Book>().WithMany().HasForeignKey("BooksId").OnDelete(DeleteBehavior.Cascade),
                j => j.HasOne<Author>().WithMany().HasForeignKey("AuthorsId").OnDelete(DeleteBehavior.Cascade),
                j =>
                {
                    j.ToTable("BookAuthors");
                    j.HasKey("AuthorsId", "BooksId");
                });
    }
}
