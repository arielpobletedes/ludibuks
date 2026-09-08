namespace Lubikus.Core.Entities;

public partial class Book
{
    private readonly List<Author> _authors = new();
    public IReadOnlyCollection<Author> Authors => _authors.AsReadOnly();

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
