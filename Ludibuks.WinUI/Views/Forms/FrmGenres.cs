using Lubikus.Core.Entities;
using Ludibuks.Application.DTOs;
using Ludibuks.WinUI.Views.Interfaces;
using System.ComponentModel;
using System.Xml.Linq;

namespace Ludibuks.WinUI.Views.Forms;

public partial class FrmGenres : System.Windows.Forms.Form, IGenreView
{
    private IReadOnlyList<GenreDto> _currentGenres = new List<GenreDto>();
    public FrmGenres()
    {
        InitializeComponent();

        this.Load += (s, e) => ViewLoaded?.Invoke(this, EventArgs.Empty);
        this.btnSaveGenre.Click += (s, e) => SaveClicked?.Invoke(this, EventArgs.Empty);
        this.btnDeleteGenre.Click += (s, e) => DeleteClicked?.Invoke(this, EventArgs.Empty);
        this.btnClearForm.Click += (s, e) => ClearClicked?.Invoke(this, EventArgs.Empty);
        this.gridGenres.SelectionChanged += (s, e) => SelectionChanged?.Invoke(this, EventArgs.Empty);
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedGenreId { get; set; } = 0;


    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string NameInput { get => txtName.Text; set => txtName.Text = value; }

    public GenreDto? SelectedGenre
    {
        get
        {
            if (gridGenres.CurrentRow?.DataBoundItem is null) return null;
            var idObj = gridGenres.CurrentRow.Cells["Id"]?.Value;
            if (idObj is int id)
            {
                return _currentGenres.FirstOrDefault(a => a.Id == id);
            }
            return null;
        }
    }

    public event EventHandler ViewLoaded;
    public event EventHandler SaveClicked;
    public event EventHandler DeleteClicked;
    public event EventHandler SelectionChanged;
    public event EventHandler ClearClicked;

    public void ClearInputs()
    {
        SelectedGenreId = 0;
        txtName.Text = string.Empty;
        gridGenres.ClearSelection();
    }

    public bool ConfirmDelete(string genreName)
    {
        var result = MessageBox.Show(
           $"¿Está seguro de que desea eliminar al género '{genreName}'?",
           "Confirmar Eliminación",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);

        return result == DialogResult.Yes;
    }

    public void SetGenreList(IReadOnlyList<GenreDto> genres)
    {
        _currentGenres = genres;

        var viewModels = genres.Select(a => new
        {
            a.Id,
            Nombre = a.Name
        }).ToList();

        gridGenres.DataSource = viewModels;
    }

    public void ShowMessage(string message, bool isError = false)
    {
        MessageBox.Show(message, isError ? "Error" : "Autores",
            MessageBoxButtons.OK, isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
    }
}
