using Ludibuks.Application.DTOs;
using Ludibuks.WinUI.Views.Interfaces;
using System.ComponentModel;

namespace Ludibuks.WinUI.Views.Forms;

public partial class FrmBooks : Form, IBookView
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
    public event EventHandler? ViewLoaded;

    [Browsable(false)]
    public event EventHandler? SaveClicked;

    public void ClearInputs()
    {
        txtTitle.Clear();
        txtIsbn.Clear();
        numPrice.Value = 0;
    }

    public void SetBookList(IReadOnlyList<BookDto> books)
    {
        gridBooks.DataSource = books.ToList();
    }

    public void ShowMessage(string message, bool isError = false)
    {
        MessageBox.Show(message, isError ? "Error" : "Éxito",
            MessageBoxButtons.OK, isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
    }
}
