namespace Ludibuks.Application.DTOs;

public record AuthorLookupDto(int Id, string Name);

public record AuthorDto(
    int Id,
    string Name,
    string? Biography,
    int BookCount
);

public record CreateAuthorDto(
    string Name,
    string? Biography
);

public record UpdateAuthorDto(
    int Id,
    string Name,
    string? Biography
);
