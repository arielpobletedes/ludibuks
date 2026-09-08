using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;

namespace Ludibuks.Application.Services;

public class AuthorAppService : IAuthorAppService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorAppService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<IReadOnlyList<AuthorLookupDto>> GetAllAuthorsLookupAsync(CancellationToken ct = default)
    {
        var authors = await _authorRepository.GetAllAsync(ct);
        return authors.Select(a => new AuthorLookupDto(a.Id, a.Name)).ToList();
    }
}
