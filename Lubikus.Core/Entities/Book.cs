namespace Lubikus.Core.Entities;

public partial class Book
{
    public int Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string Isbn { get; private set; } = string.Empty;
    public decimal Price { get; private set; }

    // Relación Many-to-Many con Author
    

    protected Book() { }

    public Book(string title, string isbn, decimal price)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("El título es requerido.");
        Title = title;
        Isbn = isbn;
        Price = price;
    }
}
