using Ludibuks.Application.DTOs;

namespace Ludibuks.Application.Interfaces;

public interface IAuthorAppService
{
    Task<IReadOnlyList<AuthorLookupDto>> GetAllAuthorsLookupAsync(CancellationToken ct = default);
    Task<IReadOnlyList<AuthorDto>> GetAllAuthorsAsync(CancellationToken ct = default);
    Task<AuthorDto?> GetAuthorByIdAsync(int id, CancellationToken ct = default);
    Task<int> CreateAuthorAsync(CreateAuthorDto dto, CancellationToken ct = default);
    Task UpdateAuthorAsync(UpdateAuthorDto dto, CancellationToken ct = default);
    Task DeleteAuthorAsync(int id, CancellationToken ct = default);
}
