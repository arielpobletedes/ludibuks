namespace Lubikus.Core.Entities;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public readonly List<Book> _books = new();
    public IReadOnlyCollection<Book> Books => _books.AsReadOnly();

    protected Genre() { }

    public Genre(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name of Genre is mandatory.");
        Name = name.Trim();
    }
    public void UpdateName(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new ArgumentException("El nombre no puede estar vacío.");

        Name = newName.Trim();
    }
}
