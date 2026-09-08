using Ludibuks.Application.DTOs;

namespace Ludibuks.WinUI.Views.Interfaces;

public interface IAuthorView
{
    int SelectedAuthorId { get; set; }
    string NameInput { get; set; }
    string BiographyInput { get; set; }

    AuthorDto? SelectedAuthor { get; }

    void SetAuthorList(IReadOnlyList<AuthorDto> authors);
    void ClearInputs();
    void ShowMessage(string message, bool isError = false);
    bool ConfirmDelete(string authorName);

    event EventHandler ViewLoaded;
    event EventHandler SaveClicked;
    event EventHandler DeleteClicked;
    event EventHandler SelectionChanged;
    event EventHandler ClearClicked;
}
