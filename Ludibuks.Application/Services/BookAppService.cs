using Lubikus.Core.Entities;
using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;

namespace Ludibuks.Application.Services;

public class BookAppService : IBookAppService
{
    private readonly IBookRepository _bookRepository; 
    private readonly IAuthorRepository _authorRepository;

    public BookAppService(IBookRepository bookRepository, IAuthorRepository authorRepository)
    {
        _bookRepository = bookRepository;
        _authorRepository = authorRepository;
    }

    public async Task<IReadOnlyList<BookDto>> GetAllBooksAsync(CancellationToken ct = default)
    {
        var books = await _bookRepository.GetAllWithAuthorsAsync(ct);

        return books.Select(book => new BookDto(
            book.Id,
            book.Title,
            book.Isbn,
            book.Price,
            book.Authors.Select(a => new AuthorLookupDto(a.Id, a.Name)).ToList()
        )).ToList();
    }

    public async Task<int> CreateBookAsync(CreateBookDto dto, CancellationToken ct = default)
    {
        if (dto.AuthorIds is null || dto.AuthorIds.Count == 0)
        {
            throw new InvalidOperationException("Un libro debe tener al menos un autor asociado.");
        }

        // 1. Obtener autores existentes desde la base de datos
        var existingAuthors = await _authorRepository.GetByIdsAsync(dto.AuthorIds, ct);

        if (existingAuthors.Count != dto.AuthorIds.Distinct().Count())
        {
            throw new InvalidOperationException("Uno o más autores especificados no existen.");
        }

        // 2. Instanciar la entidad Book y asociar los autores recuperados
        var book = new Book(dto.Title, dto.Isbn, dto.Price);

        foreach (var author in existingAuthors)
        {
            book.AddAuthor(author);
        }

        // 3. Persistir a través del repositorio
        await _bookRepository.AddAsync(book, ct);
        await _bookRepository.SaveChangesAsync(ct);

        return book.Id;
    }
}