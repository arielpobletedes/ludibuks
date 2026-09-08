using Lubikus.Core.Entities;

namespace Lubikus.Core.Interfaces.Repositories;

public interface IBookRepository
{
    Task<Book?> GetByIdWithAuthorsAsync(int id, CancellationToken ct = default);
    Task<IReadOnlyList<Book>> GetAllWithAuthorsAsync(CancellationToken ct = default);
    Task AddAsync(Book book, CancellationToken ct = default);
    Task SaveChangesAsync(CancellationToken ct = default);
}
