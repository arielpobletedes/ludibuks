using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;
using Ludibuks.WinUI.Views.Interfaces;

namespace Ludibuks.WinUI.Presenters;

public class BookPresenter
{
    private readonly IBookView _view;
    private readonly IBookAppService _bookAppService;
    private readonly IAuthorAppService _authorAppService;
    private readonly IGenreAppService _genreAppService;

    public BookPresenter(
        IBookView view,
        IBookAppService bookAppService,
        IAuthorAppService authorAppService,
        IGenreAppService genreAppService)
    {
        _view = view;
        _bookAppService = bookAppService;
        _authorAppService = authorAppService;
        _genreAppService = genreAppService;

        _view.ViewLoaded += async (s, e) => await InitializeAsync();
        _view.SaveClicked += async (s, e) => await SaveBookAsync();
    }

    private async Task InitializeAsync()
    {
        try
        {
            var authors = await _authorAppService.GetAllAuthorsLookupAsync();
            _view.SetAuthorList(authors);

            var genres = await _genreAppService.GetAllGenresLookupAsync();
            _view.SetGenreList(genres);


            await LoadBooksAsync();
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al inicializar la pantalla: {ex.Message}", isError: true);
        }
    }

    private async Task LoadBooksAsync()
    {
        var books = await _bookAppService.GetAllBooksAsync();
        _view.SetBookList(books);
    }

    private async Task SaveBookAsync()
    {
        try
        {
            var authorIds = _view.SelectedAuthorIds;

            if (authorIds.Count == 0)
            {
                _view.ShowMessage("Debes seleccionar al menos un autor para el libro.", isError: true);
                return;
            }

            var genreIds = _view.SelectedGenreIds;

            if (genreIds.Count == 0)
            {
                _view.ShowMessage("Debes seleccionar al menos un genero para el libro.", isError: true);
                return;
            }

            var dto = new CreateBookDto(
                _view.TitleInput,
                _view.IsbnInput,
                _view.PriceInput,
                authorIds,
                genreIds
            );

            await _bookAppService.CreateBookAsync(dto);

            _view.ShowMessage("Libro registrado exitosamente con sus autores.");
            _view.ClearInputs();
            await LoadBooksAsync();
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al registrar el libro: {ex.Message}", isError: true);
        }
    }
}