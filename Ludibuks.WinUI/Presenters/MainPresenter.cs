using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;
using Ludibuks.WinUI.Views.Interfaces;

namespace Ludibuks.WinUI.Presenters;

public class MainPresenter
{
    private readonly IMainView _view;
    private readonly IBookAppService _bookAppService;
    private IReadOnlyList<BookDto> _allBooks = new List<BookDto>();

    public MainPresenter(IMainView view, IBookAppService bookAppService)
    {
        _view = view;
        _bookAppService = bookAppService;

        _view.ViewLoaded += async (s, e) => await InitializeAsync();
        _view.SearchChanged += (s, e) => ApplyFilter();
        _view.BookSelected += (s, e) => UpdatePreview();
        _view.RefreshClicked += async (s, e) => await InitializeAsync();
        _view.AddBookClicked += (s, e) => _view.OpenAddBookDialog();
        _view.OpenFileClicked += (s, e) => HandleOpenFile();
    }

    private async Task InitializeAsync()
    {
        try
        {
            _allBooks = await _bookAppService.GetAllBooksAsync();

            var genres = _allBooks
                .Select(b => "Todos los Géneros")
                .Concat(_allBooks.Select(b => "General").Distinct())
                .Distinct()
                .ToList();

            _view.SetGenres(genres);
            ApplyFilter();
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al cargar el catálogo de libros: {ex.Message}", isError: true);
        }
    }

    private void ApplyFilter()
    {
        var search = _view.SearchText?.Trim().ToLowerInvariant() ?? string.Empty;
        var genre = _view.SelectedGenre;

        var filtered = _allBooks.Where(b =>
        {
            var matchesSearch = string.IsNullOrEmpty(search) ||
                b.Title.ToLowerInvariant().Contains(search) ||
                b.Isbn.ToLowerInvariant().Contains(search) ||
                b.Authors.Any(a => a.Name.ToLowerInvariant().Contains(search));

            var matchesGenre = string.IsNullOrEmpty(genre) ||
                genre == "Todos los Géneros" ||
                genre == "Todos";

            return matchesSearch && matchesGenre;
        }).ToList();

        _view.SetBookList(filtered);
        _view.SetSelectedBookPreview(filtered.FirstOrDefault());
    }

    private void UpdatePreview()
    {
        _view.SetSelectedBookPreview(_view.SelectedBook);
    }

    private void HandleOpenFile()
    {
        var selected = _view.SelectedBook;
        if (selected is null)
        {
            _view.ShowMessage("Seleccione un libro para previsualizar o abrir.", isError: true);
            return;
        }

        _view.ShowMessage($"Abriendo archivo del libro '{selected.Title}'...");
    }
}
