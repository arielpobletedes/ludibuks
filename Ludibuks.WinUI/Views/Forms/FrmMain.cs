using Ludibuks.Application.DTOs;
using Ludibuks.WinUI.Presenters;
using Ludibuks.WinUI.Views.Interfaces;
using System.ComponentModel;
using System.Diagnostics;

namespace Ludibuks.WinUI.Views.Forms;

public partial class FrmMain : Form, IMainView
{
    private readonly IServiceProvider _serviceProvider;
    private IReadOnlyList<BookDto> _currentBooks = new List<BookDto>();

    public FrmMain(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitializeComponent();

        // Conexiones de eventos de UI
        this.Load += (s, e) => ViewLoaded?.Invoke(this, EventArgs.Empty);

        this.txtSearch.TextChanged += (s, e) => SearchChanged?.Invoke(this, EventArgs.Empty);
        this.cmbGenre.SelectedIndexChanged += (s, e) => SearchChanged?.Invoke(this, EventArgs.Empty);
        this.cmbFormat.SelectedIndexChanged += (s, e) => SearchChanged?.Invoke(this, EventArgs.Empty);

        this.gridBooks.SelectionChanged += (s, e) => BookSelected?.Invoke(this, EventArgs.Empty);

        this.btnActionAdd.Click += (s, e) => AddBookClicked?.Invoke(this, EventArgs.Empty);
        this.btnActionRefresh.Click += (s, e) => RefreshClicked?.Invoke(this, EventArgs.Empty);
        this.btnActionOpenFile.Click += (s, e) => OpenFileClicked?.Invoke(this, EventArgs.Empty);
        this.btnOpenSelectedFile.Click += (s, e) => OpenFileClicked?.Invoke(this, EventArgs.Empty);

        this.btnActionAuthors.Click += (s, e) => OpenAuthorsDialog();
        this.btnResetFilter.Click += (s, e) => ResetFilters();
    }

    public void OpenAuthorsDialog()
    {
        using var scope = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.CreateScope(_serviceProvider);
        var presenter = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<AuthorPresenter>(scope.ServiceProvider);
        var frmAuthors = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<FrmAuthors>(scope.ServiceProvider);
        frmAuthors.ShowDialog(this);
    }

    [Browsable(false)]
    public string SearchText => txtSearch.Text;

    [Browsable(false)]
    public string SelectedGenre => cmbGenre.SelectedItem?.ToString() ?? string.Empty;

    [Browsable(false)]
    public BookDto? SelectedBook
    {
        get
        {
            if (gridBooks.CurrentRow?.DataBoundItem is null) return null;

            var idObj = gridBooks.CurrentRow.Cells["Id"]?.Value;
            if (idObj is int id)
            {
                return _currentBooks.FirstOrDefault(b => b.Id == id);
            }

            return null;
        }
    }

    public event EventHandler? ViewLoaded;
    public event EventHandler? SearchChanged;
    public event EventHandler? BookSelected;
    public event EventHandler? AddBookClicked;
    public event EventHandler? RefreshClicked;
    public event EventHandler? OpenFileClicked;

    public void SetBookList(IReadOnlyList<BookDto> books)
    {
        _currentBooks = books;

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

    public void SetGenres(IReadOnlyList<string> genres)
    {
        cmbGenre.DataSource = genres.ToList();
        if (cmbGenre.Items.Count > 0)
        {
            cmbGenre.SelectedIndex = 0;
        }
    }

    public void SetSelectedBookPreview(BookDto? book)
    {
        if (book is null)
        {
            lblPreviewBookTitle.Text = "Ningún libro seleccionado";
            lblPreviewAuthors.Text = "Autor: -";
            lblPreviewIsbn.Text = "ISBN: -";
            lblPreviewPrice.Text = "Precio: $0.00";
            return;
        }

        lblPreviewBookTitle.Text = book.Title;
        lblPreviewAuthors.Text = $"Autor(es): {string.Join(", ", book.Authors.Select(a => a.Name))}";
        lblPreviewIsbn.Text = $"ISBN: {book.Isbn}";
        lblPreviewPrice.Text = $"Precio: {book.Price:C2}";
    }

    public void ShowMessage(string message, bool isError = false)
    {
        MessageBox.Show(message, isError ? "Error" : "Ludibuks Info",
            MessageBoxButtons.OK, isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
    }

    public void OpenBookFile(string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
        {
            MessageBox.Show("El archivo local del ebook no se encuentra en el equipo.", "Archivo no encontrado",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            ShowMessage($"No se pudo abrir el archivo: {ex.Message}", isError: true);
        }
    }

    public void OpenAddBookDialog()
    {
        using var scope = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.CreateScope(_serviceProvider);
        var frmBooks = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<FrmBooks>(scope.ServiceProvider);
        frmBooks.ShowDialog(this);
    }

    private void ResetFilters()
    {
        txtSearch.Text = string.Empty;
        if (cmbGenre.Items.Count > 0) cmbGenre.SelectedIndex = 0;
        if (cmbFormat.Items.Count > 0) cmbFormat.SelectedIndex = 0;
    }
}
