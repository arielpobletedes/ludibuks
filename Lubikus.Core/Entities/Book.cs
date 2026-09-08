namespace Lubikus.Core.Entities;

public class Book
{
    public int Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string Isbn { get; private set; } = string.Empty;
    public decimal Price { get; private set; }

    // Relación Many-to-Many con Author
    private readonly List<Author> _authors = new();
    public IReadOnlyCollection<Author> Authors => _authors.AsReadOnly();

    protected Book() { }

    public Book(string title, string isbn, decimal price)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("El título es requerido.");
        Title = title;
        Isbn = isbn;
        Price = price;
    }

    public void AddAuthor(Author author)
    {
        ArgumentNullException.ThrowIfNull(author);

        if (!_authors.Any(a => a.Id == author.Id && author.Id != 0))
        {
            _authors.Add(author);
        }
    }

    public void RemoveAuthor(int authorId)
    {
        var author = _authors.FirstOrDefault(a => a.Id == authorId);
        if (author != null)
        {
            _authors.Remove(author);
        }
    }
}
