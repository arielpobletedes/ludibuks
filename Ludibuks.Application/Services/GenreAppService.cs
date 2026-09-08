using Lubikus.Core.Entities;
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

        public async Task<int> CreateGenreAsync(CreateGenreDto dto, CancellationToken ct = default)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
            {
                throw new ArgumentException("El nombre del género es obligatorio.");
            }

            var genre = new Genre(dto.Name);
            await _genreRepository.AddAsync(genre, ct);
            await _genreRepository.SaveChangesAsync(ct);

            return genre.Id;
        }

        public async Task DeleteGenreAsync(int id, CancellationToken ct = default)
        {
            await _genreRepository.DeleteAsync(id, ct);
            await _genreRepository.SaveChangesAsync(ct);
        }

        public async Task<IReadOnlyList<GenreDto>> GetAllGenresAsync(CancellationToken ct = default)
        {
            var genders = await _genreRepository.GetAllWithBooksAsync(ct);
            return genders.Select(a => new GenreDto(a.Id, a.Name)).ToList();
        }

        public async Task<IReadOnlyList<GenreLookupDto>> GetAllGenresLookupAsync(CancellationToken ct = default)
        {
            var genres = await _genreRepository.GetAllAsync(ct);
            return genres.Select(g => new GenreLookupDto(g.Id, g.Name)).ToList();
        }

        public async Task<GenreDto?> GetGenreByIdAsync(int id, CancellationToken ct = default)
        {
            var genre = await _genreRepository.GetByIdAsync(id, ct);
            if (genre is null) return null;

            return new GenreDto(genre.Id, genre.Name);
        }

        public async Task UpdateGenreAsync(UpdateGenreDto dto, CancellationToken ct = default)
        {
            var genre = await _genreRepository.GetByIdAsync(dto.Id, ct);
            if (genre is null)
            {
                throw new InvalidOperationException("El género especificado no existe.");
            }

            genre.UpdateName(dto.Name);
            await _genreRepository.SaveChangesAsync(ct);
        }
    }
}
