using ReaLTaiizor.Controls;

namespace Ludibuks.WinUI.Views.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            nightControlBox1 = new NightControlBox();
            lblAppTitle = new NightHeaderLabel();
            pnlTopActions = new System.Windows.Forms.Panel();
            btnActionOpenFile = new HopeButton();
            btnActionRefresh = new HopeButton();
            btnActionAuthors = new HopeButton();
            btnActionAdd = new HopeButton();
            pnlLeftFilter = new System.Windows.Forms.Panel();
            btnResetFilter = new System.Windows.Forms.Button();
            cmbFormat = new ComboBox();
            lblFormat = new NightLabel();
            cmbGenre = new ComboBox();
            lblGenre = new NightLabel();
            txtSearch = new TextBox();
            lblSearch = new NightLabel();
            lblFilterHeader = new NightLabel();
            pnlCenterListing = new System.Windows.Forms.Panel();
            gridBooks = new DataGridView();
            lblCatalogHeader = new NightLabel();
            pnlRightPreview = new System.Windows.Forms.Panel();
            btnOpenSelectedFile = new HopeButton();
            lblPreviewPrice = new NightLabel();
            lblPreviewIsbn = new NightLabel();
            lblPreviewAuthors = new NightLabel();
            lblPreviewBookTitle = new NightHeaderLabel();
            pnlCoverCard = new System.Windows.Forms.Panel();
            lblCoverIcon = new NightHeaderLabel();
            lblPreviewHeader = new NightLabel();
            pnlTopActions.SuspendLayout();
            pnlLeftFilter.SuspendLayout();
            pnlCenterListing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridBooks).BeginInit();
            pnlRightPreview.SuspendLayout();
            pnlCoverCard.SuspendLayout();
            SuspendLayout();
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1060, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.BackColor = Color.Transparent;
            lblAppTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.ForeColor = Color.FromArgb(240, 240, 240);
            lblAppTitle.Location = new Point(15, 15);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(337, 45);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "Ludibuks Ebook Manager";
            // 
            // pnlTopActions
            // 
            pnlTopActions.BackColor = Color.FromArgb(25, 28, 38);
            pnlTopActions.Controls.Add(btnActionOpenFile);
            pnlTopActions.Controls.Add(btnActionRefresh);
            pnlTopActions.Controls.Add(btnActionAuthors);
            pnlTopActions.Controls.Add(btnActionAdd);
            pnlTopActions.Controls.Add(lblAppTitle);
            pnlTopActions.Location = new Point(15, 15);
            pnlTopActions.Name = "pnlTopActions";
            pnlTopActions.Size = new Size(1170, 75);
            pnlTopActions.TabIndex = 1;
            // 
            // btnActionOpenFile
            // 
            btnActionOpenFile.BackColor = Color.FromArgb(46, 139, 87);
            btnActionOpenFile.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnActionOpenFile.ForeColor = Color.White;
            btnActionOpenFile.Location = new Point(995, 15);
            btnActionOpenFile.Name = "btnActionOpenFile";
            btnActionOpenFile.PrimaryColor = Color.FromArgb(46, 139, 87);
            btnActionOpenFile.Size = new Size(155, 45);
            btnActionOpenFile.TabIndex = 4;
            btnActionOpenFile.Text = "📖 Abrir Ebook";
            btnActionOpenFile.TextColor = Color.White;
            // 
            // btnActionRefresh
            // 
            btnActionRefresh.BackColor = Color.FromArgb(78, 88, 117);
            btnActionRefresh.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnActionRefresh.ForeColor = Color.White;
            btnActionRefresh.Location = new Point(830, 15);
            btnActionRefresh.Name = "btnActionRefresh";
            btnActionRefresh.PrimaryColor = Color.FromArgb(78, 88, 117);
            btnActionRefresh.Size = new Size(150, 45);
            btnActionRefresh.TabIndex = 3;
            btnActionRefresh.Text = "🔄 Actualizar";
            btnActionRefresh.TextColor = Color.White;
            // 
            // btnActionAuthors
            // 
            btnActionAuthors.BackColor = Color.FromArgb(32, 178, 170);
            btnActionAuthors.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnActionAuthors.ForeColor = Color.White;
            btnActionAuthors.Location = new Point(665, 15);
            btnActionAuthors.Name = "btnActionAuthors";
            btnActionAuthors.PrimaryColor = Color.FromArgb(32, 178, 170);
            btnActionAuthors.Size = new Size(150, 45);
            btnActionAuthors.TabIndex = 2;
            btnActionAuthors.Text = "👥 Autores";
            btnActionAuthors.TextColor = Color.White;
            // 
            // btnActionAdd
            // 
            btnActionAdd.BackColor = Color.FromArgb(64, 158, 255);
            btnActionAdd.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnActionAdd.ForeColor = Color.White;
            btnActionAdd.Location = new Point(490, 15);
            btnActionAdd.Name = "btnActionAdd";
            btnActionAdd.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnActionAdd.Size = new Size(160, 45);
            btnActionAdd.TabIndex = 1;
            btnActionAdd.Text = "➕ Nuevo Libro";
            btnActionAdd.TextColor = Color.White;
            // 
            // pnlLeftFilter
            // 
            pnlLeftFilter.BackColor = Color.FromArgb(33, 37, 48);
            pnlLeftFilter.Controls.Add(btnResetFilter);
            pnlLeftFilter.Controls.Add(cmbFormat);
            pnlLeftFilter.Controls.Add(lblFormat);
            pnlLeftFilter.Controls.Add(cmbGenre);
            pnlLeftFilter.Controls.Add(lblGenre);
            pnlLeftFilter.Controls.Add(txtSearch);
            pnlLeftFilter.Controls.Add(lblSearch);
            pnlLeftFilter.Controls.Add(lblFilterHeader);
            pnlLeftFilter.Location = new Point(15, 100);
            pnlLeftFilter.Name = "pnlLeftFilter";
            pnlLeftFilter.Size = new Size(260, 630);
            pnlLeftFilter.TabIndex = 2;
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.FromArgb(43, 48, 62);
            btnResetFilter.FlatAppearance.BorderSize = 0;
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.Font = new Font("Segoe UI", 9F);
            btnResetFilter.ForeColor = Color.FromArgb(200, 205, 220);
            btnResetFilter.Location = new Point(15, 275);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(230, 35);
            btnResetFilter.TabIndex = 7;
            btnResetFilter.Text = "Limpiar Filtros";
            btnResetFilter.UseVisualStyleBackColor = false;
            // 
            // cmbFormat
            // 
            cmbFormat.BackColor = Color.FromArgb(43, 48, 62);
            cmbFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormat.FlatStyle = FlatStyle.Flat;
            cmbFormat.Font = new Font("Segoe UI", 9.5F);
            cmbFormat.ForeColor = Color.FromArgb(230, 230, 230);
            cmbFormat.FormattingEnabled = true;
            cmbFormat.Items.AddRange(new object[] { "Todos los Formatos", "EPUB", "PDF", "MOBI" });
            cmbFormat.Location = new Point(15, 215);
            cmbFormat.Name = "cmbFormat";
            cmbFormat.Size = new Size(230, 33);
            cmbFormat.TabIndex = 6;
            // 
            // lblFormat
            // 
            lblFormat.AutoSize = true;
            lblFormat.BackColor = Color.Transparent;
            lblFormat.Font = new Font("Segoe UI", 9F);
            lblFormat.ForeColor = Color.FromArgb(180, 185, 200);
            lblFormat.Location = new Point(15, 185);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(80, 25);
            lblFormat.TabIndex = 5;
            lblFormat.Text = "Formato";
            // 
            // cmbGenre
            // 
            cmbGenre.BackColor = Color.FromArgb(43, 48, 62);
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FlatStyle = FlatStyle.Flat;
            cmbGenre.Font = new Font("Segoe UI", 9.5F);
            cmbGenre.ForeColor = Color.FromArgb(230, 230, 230);
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(15, 135);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(230, 33);
            cmbGenre.TabIndex = 4;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.BackColor = Color.Transparent;
            lblGenre.Font = new Font("Segoe UI", 9F);
            lblGenre.ForeColor = Color.FromArgb(180, 185, 200);
            lblGenre.Location = new Point(15, 105);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(69, 25);
            lblGenre.TabIndex = 3;
            lblGenre.Text = "Género";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(43, 48, 62);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.ForeColor = Color.FromArgb(230, 230, 230);
            txtSearch.Location = new Point(15, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 33);
            txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 9F);
            lblSearch.ForeColor = Color.FromArgb(180, 185, 200);
            lblSearch.Location = new Point(15, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(190, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Título / Autor / ISBN";
            // 
            // lblFilterHeader
            // 
            lblFilterHeader.AutoSize = true;
            lblFilterHeader.BackColor = Color.Transparent;
            lblFilterHeader.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblFilterHeader.ForeColor = Color.FromArgb(220, 225, 235);
            lblFilterHeader.Location = new Point(15, 0);
            lblFilterHeader.Name = "lblFilterHeader";
            lblFilterHeader.Size = new Size(224, 30);
            lblFilterHeader.TabIndex = 0;
            lblFilterHeader.Text = "🔍 Criterios Búsqueda";
            // 
            // pnlCenterListing
            // 
            pnlCenterListing.BackColor = Color.FromArgb(33, 37, 48);
            pnlCenterListing.Controls.Add(gridBooks);
            pnlCenterListing.Controls.Add(lblCatalogHeader);
            pnlCenterListing.Location = new Point(290, 100);
            pnlCenterListing.Name = "pnlCenterListing";
            pnlCenterListing.Size = new Size(570, 630);
            pnlCenterListing.TabIndex = 3;
            // 
            // gridBooks
            // 
            gridBooks.AllowUserToAddRows = false;
            gridBooks.AllowUserToDeleteRows = false;
            gridBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridBooks.BackgroundColor = Color.FromArgb(33, 37, 48);
            gridBooks.BorderStyle = BorderStyle.None;
            gridBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(200, 205, 220);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 28, 38);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridBooks.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 37, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(220, 225, 235);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 65, 95);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridBooks.DefaultCellStyle = dataGridViewCellStyle2;
            gridBooks.EnableHeadersVisualStyles = false;
            gridBooks.GridColor = Color.FromArgb(45, 50, 65);
            gridBooks.Location = new Point(15, 45);
            gridBooks.MultiSelect = false;
            gridBooks.Name = "gridBooks";
            gridBooks.ReadOnly = true;
            gridBooks.RowHeadersVisible = false;
            gridBooks.RowHeadersWidth = 51;
            gridBooks.RowTemplate.Height = 35;
            gridBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBooks.Size = new Size(540, 570);
            gridBooks.TabIndex = 1;
            // 
            // lblCatalogHeader
            // 
            lblCatalogHeader.AutoSize = true;
            lblCatalogHeader.BackColor = Color.Transparent;
            lblCatalogHeader.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblCatalogHeader.ForeColor = Color.FromArgb(220, 225, 235);
            lblCatalogHeader.Location = new Point(15, 10);
            lblCatalogHeader.Name = "lblCatalogHeader";
            lblCatalogHeader.Size = new Size(257, 30);
            lblCatalogHeader.TabIndex = 0;
            lblCatalogHeader.Text = "📚 Catálogo de Archivos";
            // 
            // pnlRightPreview
            // 
            pnlRightPreview.BackColor = Color.FromArgb(33, 37, 48);
            pnlRightPreview.Controls.Add(btnOpenSelectedFile);
            pnlRightPreview.Controls.Add(lblPreviewPrice);
            pnlRightPreview.Controls.Add(lblPreviewIsbn);
            pnlRightPreview.Controls.Add(lblPreviewAuthors);
            pnlRightPreview.Controls.Add(lblPreviewBookTitle);
            pnlRightPreview.Controls.Add(pnlCoverCard);
            pnlRightPreview.Controls.Add(lblPreviewHeader);
            pnlRightPreview.Location = new Point(875, 100);
            pnlRightPreview.Name = "pnlRightPreview";
            pnlRightPreview.Size = new Size(310, 630);
            pnlRightPreview.TabIndex = 4;
            // 
            // btnOpenSelectedFile
            // 
            btnOpenSelectedFile.BackColor = Color.FromArgb(46, 139, 87);
            btnOpenSelectedFile.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnOpenSelectedFile.ForeColor = Color.White;
            btnOpenSelectedFile.Location = new Point(15, 560);
            btnOpenSelectedFile.Name = "btnOpenSelectedFile";
            btnOpenSelectedFile.PrimaryColor = Color.FromArgb(46, 139, 87);
            btnOpenSelectedFile.Size = new Size(280, 45);
            btnOpenSelectedFile.TabIndex = 6;
            btnOpenSelectedFile.Text = "🚀 Abrir Archivo";
            btnOpenSelectedFile.TextColor = Color.White;
            // 
            // lblPreviewPrice
            // 
            lblPreviewPrice.AutoSize = true;
            lblPreviewPrice.BackColor = Color.Transparent;
            lblPreviewPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPreviewPrice.ForeColor = Color.FromArgb(64, 158, 255);
            lblPreviewPrice.Location = new Point(15, 450);
            lblPreviewPrice.Name = "lblPreviewPrice";
            lblPreviewPrice.Size = new Size(116, 28);
            lblPreviewPrice.TabIndex = 5;
            lblPreviewPrice.Text = "Precio: $0.00";
            // 
            // lblPreviewIsbn
            // 
            lblPreviewIsbn.AutoSize = true;
            lblPreviewIsbn.BackColor = Color.Transparent;
            lblPreviewIsbn.Font = new Font("Segoe UI", 9F);
            lblPreviewIsbn.ForeColor = Color.FromArgb(180, 185, 200);
            lblPreviewIsbn.Location = new Point(15, 410);
            lblPreviewIsbn.Name = "lblPreviewIsbn";
            lblPreviewIsbn.Size = new Size(60, 25);
            lblPreviewIsbn.TabIndex = 4;
            lblPreviewIsbn.Text = "ISBN: -";
            // 
            // lblPreviewAuthors
            // 
            lblPreviewAuthors.AutoSize = true;
            lblPreviewAuthors.BackColor = Color.Transparent;
            lblPreviewAuthors.Font = new Font("Segoe UI", 9.5F);
            lblPreviewAuthors.ForeColor = Color.FromArgb(200, 205, 220);
            lblPreviewAuthors.Location = new Point(15, 370);
            lblPreviewAuthors.Name = "lblPreviewAuthors";
            lblPreviewAuthors.Size = new Size(95, 27);
            lblPreviewAuthors.TabIndex = 3;
            lblPreviewAuthors.Text = "Autor: N/A";
            // 
            // lblPreviewBookTitle
            // 
            lblPreviewBookTitle.BackColor = Color.Transparent;
            lblPreviewBookTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPreviewBookTitle.ForeColor = Color.White;
            lblPreviewBookTitle.Location = new Point(15, 300);
            lblPreviewBookTitle.Name = "lblPreviewBookTitle";
            lblPreviewBookTitle.Size = new Size(280, 60);
            lblPreviewBookTitle.TabIndex = 2;
            lblPreviewBookTitle.Text = "Seleccione un Libro";
            // 
            // pnlCoverCard
            // 
            pnlCoverCard.BackColor = Color.FromArgb(25, 28, 38);
            pnlCoverCard.Controls.Add(lblCoverIcon);
            pnlCoverCard.Location = new Point(55, 60);
            pnlCoverCard.Name = "pnlCoverCard";
            pnlCoverCard.Size = new Size(200, 220);
            pnlCoverCard.TabIndex = 1;
            // 
            // lblCoverIcon
            // 
            lblCoverIcon.AutoSize = true;
            lblCoverIcon.BackColor = Color.Transparent;
            lblCoverIcon.Font = new Font("Segoe UI", 48F);
            lblCoverIcon.ForeColor = Color.FromArgb(100, 110, 135);
            lblCoverIcon.Location = new Point(45, 45);
            lblCoverIcon.Name = "lblCoverIcon";
            lblCoverIcon.Size = new Size(157, 128);
            lblCoverIcon.TabIndex = 0;
            lblCoverIcon.Text = "📖";
            // 
            // lblPreviewHeader
            // 
            lblPreviewHeader.AutoSize = true;
            lblPreviewHeader.BackColor = Color.Transparent;
            lblPreviewHeader.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblPreviewHeader.ForeColor = Color.FromArgb(220, 225, 235);
            lblPreviewHeader.Location = new Point(15, 10);
            lblPreviewHeader.Name = "lblPreviewHeader";
            lblPreviewHeader.Size = new Size(239, 30);
            lblPreviewHeader.TabIndex = 0;
            lblPreviewHeader.Text = "👁️ Previsualización";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 36);
            ClientSize = new Size(1200, 745);
            Controls.Add(pnlRightPreview);
            Controls.Add(pnlCenterListing);
            Controls.Add(pnlLeftFilter);
            Controls.Add(pnlTopActions);
            Controls.Add(nightControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ludibuks Ebook Manager";
            pnlTopActions.ResumeLayout(false);
            pnlTopActions.PerformLayout();
            pnlLeftFilter.ResumeLayout(false);
            pnlLeftFilter.PerformLayout();
            pnlCenterListing.ResumeLayout(false);
            pnlCenterListing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridBooks).EndInit();
            pnlRightPreview.ResumeLayout(false);
            pnlRightPreview.PerformLayout();
            pnlCoverCard.ResumeLayout(false);
            pnlCoverCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NightControlBox nightControlBox1;
        private NightHeaderLabel lblAppTitle;
        private System.Windows.Forms.Panel pnlTopActions;
        private HopeButton btnActionAdd;
        private HopeButton btnActionAuthors;
        private HopeButton btnActionRefresh;
        private HopeButton btnActionOpenFile;
        private System.Windows.Forms.Panel pnlLeftFilter;
        private NightLabel lblFilterHeader;
        private NightLabel lblSearch;
        private TextBox txtSearch;
        private NightLabel lblGenre;
        private ComboBox cmbGenre;
        private NightLabel lblFormat;
        private ComboBox cmbFormat;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Panel pnlCenterListing;
        private NightLabel lblCatalogHeader;
        private DataGridView gridBooks;
        private System.Windows.Forms.Panel pnlRightPreview;
        private NightLabel lblPreviewHeader;
        private System.Windows.Forms.Panel pnlCoverCard;
        private NightHeaderLabel lblCoverIcon;
        private NightHeaderLabel lblPreviewBookTitle;
        private NightLabel lblPreviewAuthors;
        private NightLabel lblPreviewIsbn;
        private NightLabel lblPreviewPrice;
        private HopeButton btnOpenSelectedFile;
    }
}
