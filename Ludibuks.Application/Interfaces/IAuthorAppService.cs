using Ludibuks.Application.DTOs;

namespace Ludibuks.Application.Interfaces;

public interface IAuthorAppService
{
    Task<IReadOnlyList<AuthorLookupDto>> GetAllAuthorsLookupAsync(CancellationToken ct = default);
}
