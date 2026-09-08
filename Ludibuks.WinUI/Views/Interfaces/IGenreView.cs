using Ludibuks.Application.DTOs;

namespace Ludibuks.WinUI.Views.Interfaces;

public interface IGenreView
{
    int SelectedGenreId { get; set; }
    string NameInput { get; set; }

    GenreDto? SelectedGenre { get; }

    void SetGenreList(IReadOnlyList<GenreDto> genres);
    void ClearInputs();
    void ShowMessage(string message, bool isError = false);
    bool ConfirmDelete(string genreName);

    event EventHandler ViewLoaded;
    event EventHandler SaveClicked;
    event EventHandler DeleteClicked;
    event EventHandler SelectionChanged;
    event EventHandler ClearClicked;

}
