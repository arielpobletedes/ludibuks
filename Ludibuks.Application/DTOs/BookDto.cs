namespace Ludibuks.Application.DTOs;

public record BookDto(
    int Id,
    string Title,
    string Isbn,
    decimal Price,
    IReadOnlyList<AuthorLookupDto> Authors
);

public record CreateBookDto(
    string Title,
    string Isbn,
    decimal Price,
    IReadOnlyList<int> AuthorIds
);
