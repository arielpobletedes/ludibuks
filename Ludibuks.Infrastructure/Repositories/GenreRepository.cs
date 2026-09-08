using Lubikus.Core.Entities;
using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Ludibuks.Infrastructure.Repositories;

public class GenreRepository : IGenreRepository
{
    private readonly LudibuksDbContext _context;

    public GenreRepository(LudibuksDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Genre>> GetByIdsAsync(IEnumerable<int> ids, CancellationToken ct = default)
    {
        return await _context.Genres
            .Where(a => ids.Contains(a.Id))
            .ToListAsync(ct);
    }

    public async Task<IReadOnlyList<Genre>> GetAllAsync(CancellationToken ct = default)
    {
        return await _context.Genres
            .AsNoTracking()
            .ToListAsync(ct);
    }

    public async Task<Genre?> GetByIdAsync(int id, CancellationToken ct = default)
    {
        return await _context.Genres.FindAsync(new object[] { id }, ct);
    }

    public async Task<IReadOnlyList<Genre>> GetAllWithBooksAsync(CancellationToken ct = default)
    {
        return await _context.Genres
            .Include(a => a.Books)
            .AsNoTracking()
            .ToListAsync(ct);
    }

    public async Task AddAsync(Genre genre, CancellationToken ct = default)
    {
        await _context.Genres.AddAsync(genre, ct);
    }

    public async Task DeleteAsync(int id, CancellationToken ct = default)
    {
        var genre = await _context.Genres.FindAsync(new object[] { id }, ct);
        if (genre != null)
        {
            _context.Genres.Remove(genre);
        }
    }

    public async Task SaveChangesAsync(CancellationToken ct = default)
    {
        await _context.SaveChangesAsync(ct);
    }
}
