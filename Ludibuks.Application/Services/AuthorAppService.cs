using Lubikus.Core.Entities;
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

    public async Task<IReadOnlyList<AuthorDto>> GetAllAuthorsAsync(CancellationToken ct = default)
    {
        var authors = await _authorRepository.GetAllWithBooksAsync(ct);
        return authors.Select(a => new AuthorDto(a.Id, a.Name, a.Biography, a.Books.Count)).ToList();
    }

    public async Task<AuthorDto?> GetAuthorByIdAsync(int id, CancellationToken ct = default)
    {
        var author = await _authorRepository.GetByIdAsync(id, ct);
        if (author is null) return null;

        return new AuthorDto(author.Id, author.Name, author.Biography, author.Books.Count);
    }

    public async Task<int> CreateAuthorAsync(CreateAuthorDto dto, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
        {
            throw new ArgumentException("El nombre del autor es obligatorio.");
        }

        var author = new Author(dto.Name, dto.Biography);
        await _authorRepository.AddAsync(author, ct);
        await _authorRepository.SaveChangesAsync(ct);

        return author.Id;
    }

    public async Task UpdateAuthorAsync(UpdateAuthorDto dto, CancellationToken ct = default)
    {
        var author = await _authorRepository.GetByIdAsync(dto.Id, ct);
        if (author is null)
        {
            throw new InvalidOperationException("El autor especificado no existe.");
        }

        author.UpdateName(dto.Name);
        await _authorRepository.SaveChangesAsync(ct);
    }

    public async Task DeleteAuthorAsync(int id, CancellationToken ct = default)
    {
        await _authorRepository.DeleteAsync(id, ct);
        await _authorRepository.SaveChangesAsync(ct);
    }
}
