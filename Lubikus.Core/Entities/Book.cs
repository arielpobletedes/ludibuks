namespace Lubikus.Core.Entities;

public class Book
{
    public int Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string Isbn { get; private set; } = string.Empty;
    public decimal Price { get; private set; }

    // Constructor para EF Core y creación
    protected Book() { }

    public Book(string title, string isbn, decimal price)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("El título es requerido.");
        Title = title;
        Isbn = isbn;
        Price = price;
    }

    public void UpdatePrice(decimal newPrice)
    {
        if (newPrice < 0) throw new ArgumentException("El precio no puede ser negativo.");
        Price = newPrice;
    }
}
