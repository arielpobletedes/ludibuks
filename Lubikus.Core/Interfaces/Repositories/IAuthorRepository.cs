using Lubikus.Core.Entities;

namespace Lubikus.Core.Interfaces.Repositories;

public interface IAuthorRepository
{
    Task<Author?> GetByIdAsync(int id, CancellationToken ct = default);
    Task<IReadOnlyList<Author>> GetByIdsAsync(IEnumerable<int> ids, CancellationToken ct = default);
    Task<IReadOnlyList<Author>> GetAllAsync(CancellationToken ct = default);
    Task<IReadOnlyList<Author>> GetAllWithBooksAsync(CancellationToken ct = default);
    Task AddAsync(Author author, CancellationToken ct = default);
    Task DeleteAsync(int id, CancellationToken ct = default);
    Task SaveChangesAsync(CancellationToken ct = default);
}
