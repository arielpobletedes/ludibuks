using Ludibuks.Application.DTOs;

namespace Ludibuks.Application.Interfaces;

public interface IGenreAppService
{
    Task<IReadOnlyList<GenreLookupDto>> GetAllGenresLookupAsync(CancellationToken ct = default);
}
