using Microsoft.EntityFrameworkCore;
using Lubikus.Core.Entities;
using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Infrastructure.Data.Context;

namespace Ludibuks.Infrastructure.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly LudibuksDbContext _context;

    public AuthorRepository(LudibuksDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Author>> GetByIdsAsync(IEnumerable<int> ids, CancellationToken ct = default)
    {
        return await _context.Authors
            .Where(a => ids.Contains(a.Id))
            .ToListAsync(ct);
    }

    public async Task<IReadOnlyList<Author>> GetAllAsync(CancellationToken ct = default)
    {
        return await _context.Authors
            .AsNoTracking()
            .ToListAsync(ct);
    }
}