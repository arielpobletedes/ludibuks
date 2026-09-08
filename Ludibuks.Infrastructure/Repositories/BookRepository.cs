using Microsoft.EntityFrameworkCore;
using Lubikus.Core.Entities;
using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Infrastructure.Data.Context;

namespace Ludibuks.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly LudibuksDbContext _context;

    public BookRepository(LudibuksDbContext context)
    {
        _context = context;
    }

    public async Task<Book?> GetByIdAsync(int id, CancellationToken ct = default)
        => await _context.Books.FindAsync(new object[] { id }, ct);

    public async Task<IReadOnlyList<Book>> GetAllAsync(CancellationToken ct = default)
        => await _context.Books.AsNoTracking().ToListAsync(ct);

    public async Task AddAsync(Book book, CancellationToken ct = default)
    {
        await _context.Books.AddAsync(book, ct);
    }

    public async Task SaveChangesAsync(CancellationToken ct = default)
        => await _context.SaveChangesAsync(ct);

    public async Task<Book?> GetByIdWithAuthorsAsync(int id, CancellationToken ct = default)
    {
        return await _context.Books
            .Include(b => b.Authors)
            .FirstOrDefaultAsync(b => b.Id == id, ct);
    }

    public async Task<IReadOnlyList<Book>> GetAllWithAuthorsAsync(CancellationToken ct = default)
    {
        return await _context.Books
            .Include(b => b.Authors)
            .AsNoTracking()
            .ToListAsync(ct);
    }
}
