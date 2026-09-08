namespace Ludibuks.Application.DTOs;

public record GenreLookupDto(int Id, string Name);

public record GenreDto(
    int Id,
    string Name
);

public record CreateGenreDto(
    string Name
);

public record UpdateGenreDto(
    int Id,
    string Name
);
