using Ludibuks.Application.DTOs;

namespace Ludibuks.WinUI.Views.Interfaces;

public interface IMainView
{
    string SearchText { get; }
    string SelectedGenre { get; }

    BookDto? SelectedBook { get; }

    void SetBookList(IReadOnlyList<BookDto> books);
    void SetGenres(IReadOnlyList<string> genres);
    void SetSelectedBookPreview(BookDto? book);

    void ShowMessage(string message, bool isError = false);
    void OpenBookFile(string filePath);
    void OpenAddBookDialog();

    event EventHandler ViewLoaded;
    event EventHandler SearchChanged;
    event EventHandler BookSelected;
    event EventHandler AddBookClicked;
    event EventHandler RefreshClicked;
    event EventHandler OpenFileClicked;
}
