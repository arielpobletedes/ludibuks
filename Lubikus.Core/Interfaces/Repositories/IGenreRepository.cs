using Lubikus.Core.Entities;

namespace Lubikus.Core.Interfaces.Repositories;

public interface IGenreRepository
{
    Task<Genre?> GetByIdAsync(int id, CancellationToken ct = default);
    Task<IReadOnlyList<Genre>> GetByIdsAsync(IEnumerable<int> ids, CancellationToken ct = default);
    Task<IReadOnlyList<Genre>> GetAllAsync(CancellationToken ct = default);
    Task<IReadOnlyList<Genre>> GetAllWithBooksAsync(CancellationToken ct = default);
    Task AddAsync(Genre genre, CancellationToken ct = default);
    Task DeleteAsync(int id, CancellationToken ct = default);
    Task SaveChangesAsync(CancellationToken ct = default);
}
