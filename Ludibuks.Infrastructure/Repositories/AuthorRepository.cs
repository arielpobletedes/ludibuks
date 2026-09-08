using Lubikus.Core.Entities;
using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Ludibuks.Infrastructure.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly LudibuksDbContext _context;

    public AuthorRepository(LudibuksDbContext context)
    {
        _context = context;
    }

    public async Task<Author?> GetByIdAsync(int id, CancellationToken ct = default)
    {
        return await _context.Authors.FindAsync(new object[] { id }, ct);
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

    public async Task<IReadOnlyList<Author>> GetAllWithBooksAsync(CancellationToken ct = default)
    {
        return await _context.Authors
            .Include(a => a.Books)
            .AsNoTracking()
            .ToListAsync(ct);
    }

    public async Task AddAsync(Author author, CancellationToken ct = default)
    {
        await _context.Authors.AddAsync(author, ct);
    }

    public async Task DeleteAsync(int id, CancellationToken ct = default)
    {
        var author = await _context.Authors.FindAsync(new object[] { id }, ct);
        if (author != null)
        {
            _context.Authors.Remove(author);
        }
    }

    public async Task SaveChangesAsync(CancellationToken ct = default)
    {
        await _context.SaveChangesAsync(ct);
    }
}