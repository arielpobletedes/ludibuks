using Lubikus.Core.Entities;
using Ludibuks.Application.DTOs;
using Ludibuks.WinUI.Views.Interfaces;
using System.ComponentModel;

namespace Ludibuks.WinUI.Views.Forms;

public partial class FrmBooks : System.Windows.Forms.Form, IBookView
{
    public FrmBooks()
    {
        InitializeComponent();

        // Conexión interna de eventos de controles a los eventos de la vista
        this.Load += (s, e) => ViewLoaded?.Invoke(this, EventArgs.Empty);
        this.btnSave.Click += (s, e) => SaveClicked?.Invoke(this, EventArgs.Empty);
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string TitleInput { get => txtTitle.Text; set => txtTitle.Text = value; }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string IsbnInput { get => txtIsbn.Text; set => txtIsbn.Text = value; }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public decimal PriceInput { get => numPrice.Value; set => numPrice.Value = value; }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IReadOnlyList<int> SelectedAuthorIds
    {
        get
        {
            return clbAuthors.CheckedItems
                .OfType<AuthorLookupDto>()
                .Select(a => a.Id)
                .ToList();
        }
    }

    public IReadOnlyList<int> SelectedGenreIds => throw new NotImplementedException();

    [Browsable(false)]
    public event EventHandler? ViewLoaded;

    [Browsable(false)]
    public event EventHandler? SaveClicked;

    public void ClearInputs()
    {
        txtTitle.Text = string.Empty;
        txtIsbn.Text = string.Empty;
        numPrice.Value = 0;

        // Desmarcar todos los checks del control
        for (int i = 0; i < clbAuthors.Items.Count; i++)
        {
            clbAuthors.SetItemChecked(i, false);
        }
    }

    public void SetAuthorList(IReadOnlyList<AuthorLookupDto> authors)
    {
        clbAuthors.DataSource = authors.ToList();
        clbAuthors.DisplayMember = nameof(AuthorLookupDto.Name);
        clbAuthors.ValueMember = nameof(AuthorLookupDto.Id);
    }

    public void SetBookList(IReadOnlyList<BookDto> books)
    {
        var viewModels = books.Select(b => new
        {
            b.Id,
            b.Title,
            b.Isbn,
            Price = b.Price.ToString("C2"),
            Authors = string.Join(", ", b.Authors.Select(a => a.Name))
        }).ToList();

        gridBooks.DataSource = viewModels;
    }

    public void SetGenreList(IReadOnlyList<GenreLookupDto> genres)
    {
        clbGenres.DataSource = genres.ToList();
        clbGenres.DisplayMember = nameof(GenreLookupDto.Name);
        clbGenres.ValueMember = nameof(GenreLookupDto.Id);
    }

    public void ShowMessage(string message, bool isError = false)
    {
        MessageBox.Show(message, isError ? "Error" : "Éxito",
            MessageBoxButtons.OK, isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
    }
}
