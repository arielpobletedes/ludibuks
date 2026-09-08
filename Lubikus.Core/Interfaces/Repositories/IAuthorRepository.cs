using Lubikus.Core.Entities;

namespace Lubikus.Core.Interfaces.Repositories;

public interface IAuthorRepository
{
    Task<IReadOnlyList<Author>> GetByIdsAsync(IEnumerable<int> ids, CancellationToken ct = default);
    Task<IReadOnlyList<Author>> GetAllAsync(CancellationToken ct = default);
}
