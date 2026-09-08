using Lubikus.Core.Entities;
using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;

namespace Ludibuks.Application.Services;

public class BookAppService : IBookAppService
{
    private readonly IBookRepository _repository;

    public BookAppService(IBookRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyList<BookDto>> GetAllBooksAsync()
    {
        var books = await _repository.GetAllAsync();
        return books.Select(b => new BookDto(b.Id, b.Title, b.Isbn, b.Price)).ToList();
    }

    public async Task CreateBookAsync(CreateBookDto dto)
    {
        var book = new Book(dto.Title, dto.Isbn, dto.Price);
        await _repository.AddAsync(book);
        await _repository.SaveChangesAsync();
    }
}