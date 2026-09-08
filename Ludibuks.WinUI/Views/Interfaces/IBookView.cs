using Ludibuks.Application.DTOs;

namespace Ludibuks.WinUI.Views.Interfaces;

public interface IBookView
{
    string TitleInput { get; set; }
    string IsbnInput { get; set; }
    decimal PriceInput { get; set; }

    // Propiedad para leer los IDs marcados en el CheckedListBox
    IReadOnlyList<int> SelectedAuthorIds { get; }

    // Métodos para cargar datos en la UI
    void SetAuthorList(IReadOnlyList<AuthorLookupDto> authors);
    void SetBookList(IReadOnlyList<BookDto> books);

    void ShowMessage(string message, bool isError = false);
    void ClearInputs();

    event EventHandler ViewLoaded;
    event EventHandler SaveClicked;
}
