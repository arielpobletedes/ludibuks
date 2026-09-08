using Ludibuks.Application.DTOs;
using Ludibuks.Application.Interfaces;
using Ludibuks.WinUI.Views.Interfaces;

namespace Ludibuks.WinUI.Presenters;

public class AuthorPresenter
{
    private readonly IAuthorView _view;
    private readonly IAuthorAppService _authorAppService;

    public AuthorPresenter(IAuthorView view, IAuthorAppService authorAppService)
    {
        _view = view;
        _authorAppService = authorAppService;

        _view.ViewLoaded += async (s, e) => await LoadAuthorsAsync();
        _view.SaveClicked += async (s, e) => await SaveAuthorAsync();
        _view.DeleteClicked += async (s, e) => await DeleteAuthorAsync();
        _view.SelectionChanged += (s, e) => PopulateSelectedAuthor();
        _view.ClearClicked += (s, e) => _view.ClearInputs();
    }

    private async Task LoadAuthorsAsync()
    {
        try
        {
            var authors = await _authorAppService.GetAllAuthorsAsync();
            _view.SetAuthorList(authors);
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al cargar autores: {ex.Message}", isError: true);
        }
    }

    private async Task SaveAuthorAsync()
    {
        try
        {
            if (string.IsNullOrWhiteSpace(_view.NameInput))
            {
                _view.ShowMessage("El nombre del autor es obligatorio.", isError: true);
                return;
            }

            if (_view.SelectedAuthorId == 0)
            {
                var dto = new CreateAuthorDto(_view.NameInput, _view.BiographyInput);
                await _authorAppService.CreateAuthorAsync(dto);
                _view.ShowMessage("Autor registrado exitosamente.");
            }
            else
            {
                var dto = new UpdateAuthorDto(_view.SelectedAuthorId, _view.NameInput, _view.BiographyInput);
                await _authorAppService.UpdateAuthorAsync(dto);
                _view.ShowMessage("Autor actualizado exitosamente.");
            }

            _view.ClearInputs();
            await LoadAuthorsAsync();
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al guardar autor: {ex.Message}", isError: true);
        }
    }

    private async Task DeleteAuthorAsync()
    {
        try
        {
            var selected = _view.SelectedAuthor;
            if (selected is null || _view.SelectedAuthorId == 0)
            {
                _view.ShowMessage("Seleccione un autor de la lista para eliminar.", isError: true);
                return;
            }

            if (_view.ConfirmDelete(selected.Name))
            {
                await _authorAppService.DeleteAuthorAsync(selected.Id);
                _view.ShowMessage("Autor eliminado correctamente.");
                _view.ClearInputs();
                await LoadAuthorsAsync();
            }
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al eliminar autor: {ex.Message}", isError: true);
        }
    }

    private void PopulateSelectedAuthor()
    {
        var selected = _view.SelectedAuthor;
        if (selected != null)
        {
            _view.SelectedAuthorId = selected.Id;
            _view.NameInput = selected.Name;
            _view.BiographyInput = selected.Biography ?? string.Empty;
        }
    }
}
