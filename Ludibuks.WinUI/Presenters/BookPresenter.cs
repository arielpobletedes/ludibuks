using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;
using Ludibuks.WinUI.Views.Interfaces;

namespace Ludibuks.WinUI.Presenters;

public class BookPresenter
{
    private readonly IBookView _view;
    private readonly IBookAppService _appService;

    public BookPresenter(IBookView view, IBookAppService appService)
    {
        _view = view;
        _appService = appService;

        _view.ViewLoaded += async (s, e) => await LoadBooksAsync();
        _view.SaveClicked += async (s, e) => await SaveBookAsync();
    }

    private async Task LoadBooksAsync()
    {
        try
        {
            var books = await _appService.GetAllBooksAsync();
            _view.SetBookList(books);
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al cargar libros: {ex.Message}", isError: true);
        }
    }

    private async Task SaveBookAsync()
    {
        try
        {
            var dto = new CreateBookDto(_view.TitleInput, _view.IsbnInput, _view.PriceInput);
            await _appService.CreateBookAsync(dto);
            _view.ShowMessage("Libro guardado exitosamente.");
            _view.ClearInputs();
            await LoadBooksAsync();
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al guardar: {ex.Message}", isError: true);
        }
    }
}