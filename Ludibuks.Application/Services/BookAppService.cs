using Lubikus.Core.Entities;
using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;

namespace Ludibuks.Application.Services;

public class BookAppService : IBookAppService
{
    private readonly IBookRepository _bookRepository; 
    private readonly IAuthorRepository _authorRepository;
    private readonly IGenreRepository _genreRepository;

    public BookAppService(IBookRepository bookRepository, IAuthorRepository authorRepository, IGenreRepository genreRepository)
    {
        _bookRepository = bookRepository;
        _authorRepository = authorRepository;
        _genreRepository = genreRepository;
    }

    public async Task<IReadOnlyList<BookDto>> GetAllBooksAsync(CancellationToken ct = default)
    {
        var books = await _bookRepository.GetAllWithAuthorsAsync(ct);

        return books.Select(book => new BookDto(
            book.Id,
            book.Title,
            book.Isbn,
            book.Price,
            book.Authors.Select(a => new AuthorLookupDto(a.Id, a.Name)).ToList(),
            book.Genres.Select(g => new GenreLookupDto(g.Id, g.Name)).ToList()
        )).ToList();
    }

    public async Task<int> CreateBookAsync(CreateBookDto dto, CancellationToken ct = default)
    {
        var book = new Book(dto.Title, dto.Isbn, dto.Price);

        var existingAuthors = await ExistingAuthors(dto, ct);
        if (existingAuthors == null)
            throw new InvalidOperationException("Un libro debe tener al menos un autor asociado.");
        
        foreach (var author in existingAuthors)
        {
            book.AddAuthor(author);
        }

        var existingGenres = await ExistingGenres(dto, ct);
        if (existingGenres == null)
            throw new InvalidOperationException("Un libro debe tener al menos un genero.");

        foreach (var genre in existingGenres)
        {
            book.AddGenre(genre);
        }

        // 3. Persistir a través del repositorio
        await _bookRepository.AddAsync(book, ct);
        await _bookRepository.SaveChangesAsync(ct);

        return book.Id;
    }

    async Task<IReadOnlyList<Genre>> ExistingGenres(CreateBookDto dto, CancellationToken ct = default)
    {
        if (dto.AuthorIds is null || dto.AuthorIds.Count == 0)
        {
            throw new InvalidOperationException("Un libro debe tener al menos un autor asociado.");
        }

        var existingGenres = await _genreRepository.GetByIdsAsync(dto.AuthorIds, ct);

        if (existingGenres.Count != dto.GenreIds.Distinct().Count())
        {
            throw new InvalidOperationException("Uno o más autores especificados no existen.");
        }

        return existingGenres;
    }

    async Task<IReadOnlyList<Author>> ExistingAuthors (CreateBookDto dto, CancellationToken ct = default)
    {
        if (dto.AuthorIds is null || dto.AuthorIds.Count == 0)
        {
            throw new InvalidOperationException("Un libro debe tener al menos un autor asociado.");
        }

        var existingAuthors = await _authorRepository.GetByIdsAsync(dto.AuthorIds, ct);

        if (existingAuthors.Count != dto.AuthorIds.Distinct().Count())
        {
            throw new InvalidOperationException("Uno o más autores especificados no existen.");
        }

        return existingAuthors;
    }
}