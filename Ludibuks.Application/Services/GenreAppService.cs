using Lubikus.Core.Interfaces.Repositories;
using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;

namespace Ludibuks.Application.Services
{
    public class GenreAppService : IGenreAppService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreAppService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public async Task<IReadOnlyList<GenreLookupDto>> GetAllGenresLookupAsync(CancellationToken ct = default)
        {
            var genres = await _genreRepository.GetAllAsync(ct);
            return genres.Select(g => new GenreLookupDto(g.Id, g.Name)).ToList();
        }
    }
}
