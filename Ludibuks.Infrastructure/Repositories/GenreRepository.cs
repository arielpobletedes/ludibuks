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
}
