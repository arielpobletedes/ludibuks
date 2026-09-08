namespace Lubikus.Core.Entities;

public class Author
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string? Biography { get; private set; }

    // Colección de navegación hacia Book
    private readonly List<Book> _books = new();
    public IReadOnlyCollection<Book> Books => _books.AsReadOnly();

    protected Author() { } // Requerido por EF Core

    public Author(string name, string? biography = null)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre del autor es obligatorio.");

        Name = name.Trim();
        Biography = biography;
    }

    public void UpdateName(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new ArgumentException("El nombre no puede estar vacío.");

        Name = newName.Trim();
    }
}
