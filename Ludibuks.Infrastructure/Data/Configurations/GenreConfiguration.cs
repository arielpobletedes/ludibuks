using Lubikus.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ludibuks.Infrastructure.Data.Configurations;

public class GenreConfiguration: IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.ToTable("Genres");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(40);
        
        builder.HasMany(a => a.Books)
            .WithMany(b => b.Genres)
            .UsingEntity<Dictionary<string, object>>(
                "BookGenre",
                j => j.HasOne<Book>().WithMany().HasForeignKey("BooksId").OnDelete(DeleteBehavior.Cascade),
                j => j.HasOne<Genre>().WithMany().HasForeignKey("GenresId").OnDelete(DeleteBehavior.Cascade),
                j =>
                {
                    j.ToTable("BookGenres");
                    j.HasKey("GenresId", "BooksId");
                });
    }
}

