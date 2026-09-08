using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;
using Ludibuks.WinUI.Views.Interfaces;

namespace Ludibuks.WinUI.Presenters;

public class GenrePresenter
{
    private readonly IGenreView _view;
    private readonly IGenreAppService _genreAppService;

    public GenrePresenter(IGenreView view, IGenreAppService genreAppService)
    {
        _view = view;
        _genreAppService = genreAppService;

        _view.ViewLoaded += async (s, e) => await LoadGenresAsync();
        _view.SaveClicked += async (s, e) => await SaveGenreAsync();
        _view.DeleteClicked += async (s, e) => await DeleteGenreAsync();
        _view.SelectionChanged += (s, e) => PopulateSelectedGenre();
        _view.ClearClicked += (s, e) => _view.ClearInputs();
    }

    private async Task LoadGenresAsync()
    {
        try
        {
            var genres = await _genreAppService.GetAllGenresAsync();
            _view.SetGenreList(genres);
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al cargar generos: {ex.Message}", isError: true);
        }
    }

    private async Task SaveGenreAsync()
    {
        try
        {
            if (string.IsNullOrWhiteSpace(_view.NameInput))
            {
                _view.ShowMessage("El nombre del género es obligatorio.", isError: true);
                return;
            }

            if (_view.SelectedGenreId == 0)
            {
                var dto = new CreateGenreDto(_view.NameInput);
                await _genreAppService.CreateGenreAsync(dto);
                _view.ShowMessage("Género registrado exitosamente.");
            }
            else
            {
                var dto = new UpdateGenreDto(_view.SelectedGenreId, _view.NameInput);
                await _genreAppService.UpdateGenreAsync(dto);
                _view.ShowMessage("Género actualizado exitosamente.");
            }

            _view.ClearInputs();
            await LoadGenresAsync();
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al guardar género: {ex.Message}", isError: true);
        }
    }

    private async Task DeleteGenreAsync()
    {
        try
        {
            var selected = _view.SelectedGenre;
            if (selected is null || _view.SelectedGenreId == 0)
            {
                _view.ShowMessage("Seleccione un género de la lista para eliminar.", isError: true);
                return;
            }

            if (_view.ConfirmDelete(selected.Name))
            {
                await _genreAppService.DeleteGenreAsync(selected.Id);
                _view.ShowMessage("Género eliminado correctamente.");
                _view.ClearInputs();
                await LoadGenresAsync();
            }
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al eliminar genero: {ex.Message}", isError: true);
        }
    }

    private void PopulateSelectedGenre()
    {
        var selected = _view.SelectedGenre;
        if (selected != null)
        {
            _view.SelectedGenreId = selected.Id;
            _view.NameInput = selected.Name;
        }
    }
}
