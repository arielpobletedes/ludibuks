using Ludibuks.Application.DTOs;
using Ludibuks.WinUI.Views.Interfaces;
using System.ComponentModel;

namespace Ludibuks.WinUI.Views.Forms;

public partial class FrmAuthors : System.Windows.Forms.Form, IAuthorView
{
    private IReadOnlyList<AuthorDto> _currentAuthors = new List<AuthorDto>();

    public FrmAuthors()
    {
        InitializeComponent();

        this.Load += (s, e) => ViewLoaded?.Invoke(this, EventArgs.Empty);
        this.btnSaveAuthor.Click += (s, e) => SaveClicked?.Invoke(this, EventArgs.Empty);
        this.btnDeleteAuthor.Click += (s, e) => DeleteClicked?.Invoke(this, EventArgs.Empty);
        this.btnClearForm.Click += (s, e) => ClearClicked?.Invoke(this, EventArgs.Empty);
        this.gridAuthors.SelectionChanged += (s, e) => SelectionChanged?.Invoke(this, EventArgs.Empty);
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedAuthorId { get; set; } = 0;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string NameInput { get => txtName.Text; set => txtName.Text = value; }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string BiographyInput { get => txtBiography.Text; set => txtBiography.Text = value; }

    [Browsable(false)]
    public AuthorDto? SelectedAuthor
    {
        get
        {
            if (gridAuthors.CurrentRow?.DataBoundItem is null) return null;
            var idObj = gridAuthors.CurrentRow.Cells["Id"]?.Value;
            if (idObj is int id)
            {
                return _currentAuthors.FirstOrDefault(a => a.Id == id);
            }
            return null;
        }
    }

    public event EventHandler? ViewLoaded;
    public event EventHandler? SaveClicked;
    public event EventHandler? DeleteClicked;
    public event EventHandler? SelectionChanged;
    public event EventHandler? ClearClicked;

    public void SetAuthorList(IReadOnlyList<AuthorDto> authors)
    {
        _currentAuthors = authors;

        var viewModels = authors.Select(a => new
        {
            a.Id,
            Nombre = a.Name,
            Biografía = a.Biography ?? "-",
            Libros = a.BookCount
        }).ToList();

        gridAuthors.DataSource = viewModels;
    }

    public void ClearInputs()
    {
        SelectedAuthorId = 0;
        txtName.Text = string.Empty;
        txtBiography.Text = string.Empty;
        gridAuthors.ClearSelection();
    }

    public void ShowMessage(string message, bool isError = false)
    {
        MessageBox.Show(message, isError ? "Error" : "Autores",
            MessageBoxButtons.OK, isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
    }

    public bool ConfirmDelete(string authorName)
    {
        var result = MessageBox.Show(
            $"¿Está seguro de que desea eliminar al autor '{authorName}'?",
            "Confirmar Eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        return result == DialogResult.Yes;
    }
}
