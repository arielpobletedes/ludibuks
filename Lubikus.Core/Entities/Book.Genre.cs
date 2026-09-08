namespace Lubikus.Core.Entities;

public partial class Book
{
    private readonly List<Genre> _genres = new();
    public IReadOnlyCollection<Genre> Genres => _genres.AsReadOnly();
    public void AddGenre(Genre genre)
    {
        ArgumentNullException.ThrowIfNull(genre);

        if (!_genres.Any(a => a.Id == genre.Id && genre.Id != 0))
        {
            _genres.Add(genre);
        }
    }

    public void RemoveGender(int genreId)
    {
        var genre = _genres.FirstOrDefault(a => a.Id == genreId);
        if (genre != null)
        {
            _genres.Remove(genre);
        }
    }

}
