using Ludibuks.Application.DTOs;

namespace Ludibuks.Application.Interfaces;

public interface IGenreAppService
{
    Task<IReadOnlyList<GenreLookupDto>> GetAllGenresLookupAsync(CancellationToken ct = default);
    Task<IReadOnlyList<GenreDto>> GetAllGenresAsync(CancellationToken ct = default);
    Task<GenreDto?> GetGenreByIdAsync(int id, CancellationToken ct = default);
    Task<int> CreateGenreAsync(CreateGenreDto dto, CancellationToken ct = default);
    Task UpdateGenreAsync(UpdateGenreDto dto, CancellationToken ct = default);
    Task DeleteGenreAsync(int id, CancellationToken ct = default);
}
