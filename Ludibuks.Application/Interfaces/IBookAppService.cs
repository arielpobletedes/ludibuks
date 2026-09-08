using Ludibuks.Application.DTOs;

namespace Ludibuks.Application.Interfaces;

public interface IBookAppService
{
    Task<IReadOnlyList<BookDto>> GetAllBooksAsync(CancellationToken ct = default);
    Task<int> CreateBookAsync(CreateBookDto dto, CancellationToken ct = default);
}
