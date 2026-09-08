using Ludibuks.Application.DTOs;

namespace Ludibuks.Application.Interfaces;

public interface IBookAppService
{
    Task<IReadOnlyList<BookDto>> GetAllBooksAsync();
    Task CreateBookAsync(CreateBookDto dto);
}
