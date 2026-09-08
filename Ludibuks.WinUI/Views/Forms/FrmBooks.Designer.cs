using ReaLTaiizor.Controls;

namespace Ludibuks.WinUI.Views.Forms
{
    partial class FrmBooks
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
            lblHeader = new NightHeaderLabel();
            lblTitle = new NightLabel();
            txtTitle = new TextBox();
            lblIsbn = new NightLabel();
            txtIsbn = new TextBox();
            lblPrice = new NightLabel();
            numPrice = new NumericUpDown();
            btnSave = new System.Windows.Forms.Button();
            lblAuthors = new NightLabel();
            clbAuthors = new CheckedListBox();
            gridBooks = new DataGridView();
            lblGridHeader = new NightLabel();
            pnlFormCard = new System.Windows.Forms.Panel();
            pnlAuthorsCard = new ReaLTaiizor.Controls.Panel();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBooks).BeginInit();
            pnlFormCard.SuspendLayout();
            pnlAuthorsCard.SuspendLayout();
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
            nightControlBox1.Location = new Point(810, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(240, 240, 240);
            lblHeader.Location = new Point(25, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(330, 45);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Ludibuks Ebook Library";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(180, 185, 200);
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Título del Libro";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(43, 48, 62);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.ForeColor = Color.FromArgb(230, 230, 230);
            txtTitle.Location = new Point(15, 42);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(390, 34);
            txtTitle.TabIndex = 1;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.BackColor = Color.Transparent;
            lblIsbn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsbn.ForeColor = Color.FromArgb(180, 185, 200);
            lblIsbn.Location = new Point(15, 90);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(51, 25);
            lblIsbn.TabIndex = 2;
            lblIsbn.Text = "ISBN";
            // 
            // txtIsbn
            // 
            txtIsbn.BackColor = Color.FromArgb(43, 48, 62);
            txtIsbn.BorderStyle = BorderStyle.FixedSingle;
            txtIsbn.Font = new Font("Segoe UI", 10F);
            txtIsbn.ForeColor = Color.FromArgb(230, 230, 230);
            txtIsbn.Location = new Point(15, 117);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(390, 34);
            txtIsbn.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(180, 185, 200);
            lblPrice.Location = new Point(15, 165);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(60, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Precio";
            // 
            // numPrice
            // 
            numPrice.BackColor = Color.FromArgb(43, 48, 62);
            numPrice.BorderStyle = BorderStyle.FixedSingle;
            numPrice.DecimalPlaces = 2;
            numPrice.Font = new Font("Segoe UI", 10F);
            numPrice.ForeColor = Color.FromArgb(230, 230, 230);
            numPrice.Location = new Point(15, 192);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(180, 34);
            numPrice.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 158, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(215, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 42);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar Libro";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblAuthors
            // 
            lblAuthors.AutoSize = true;
            lblAuthors.BackColor = Color.Transparent;
            lblAuthors.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthors.ForeColor = Color.FromArgb(180, 185, 200);
            lblAuthors.Location = new Point(15, 15);
            lblAuthors.Name = "lblAuthors";
            lblAuthors.Size = new Size(180, 25);
            lblAuthors.TabIndex = 0;
            lblAuthors.Text = "Seleccionar Autor(es)";
            // 
            // clbAuthors
            // 
            clbAuthors.BackColor = Color.FromArgb(43, 48, 62);
            clbAuthors.BorderStyle = BorderStyle.None;
            clbAuthors.Font = new Font("Segoe UI", 9.5F);
            clbAuthors.ForeColor = Color.FromArgb(230, 230, 230);
            clbAuthors.FormattingEnabled = true;
            clbAuthors.Location = new Point(15, 45);
            clbAuthors.Name = "clbAuthors";
            clbAuthors.Size = new Size(420, 180);
            clbAuthors.TabIndex = 1;
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
            gridBooks.Location = new Point(25, 370);
            gridBooks.MultiSelect = false;
            gridBooks.Name = "gridBooks";
            gridBooks.ReadOnly = true;
            gridBooks.RowHeadersVisible = false;
            gridBooks.RowHeadersWidth = 51;
            gridBooks.RowTemplate.Height = 35;
            gridBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBooks.Size = new Size(895, 240);
            gridBooks.TabIndex = 4;
            // 
            // lblGridHeader
            // 
            lblGridHeader.AutoSize = true;
            lblGridHeader.BackColor = Color.Transparent;
            lblGridHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridHeader.ForeColor = Color.FromArgb(220, 225, 235);
            lblGridHeader.Location = new Point(25, 332);
            lblGridHeader.Name = "lblGridHeader";
            lblGridHeader.Size = new Size(224, 32);
            lblGridHeader.TabIndex = 3;
            lblGridHeader.Text = "Catálogo de Libros";
            // 
            // pnlFormCard
            // 
            pnlFormCard.BackColor = Color.FromArgb(33, 37, 48);
            pnlFormCard.Controls.Add(lblTitle);
            pnlFormCard.Controls.Add(txtTitle);
            pnlFormCard.Controls.Add(lblIsbn);
            pnlFormCard.Controls.Add(txtIsbn);
            pnlFormCard.Controls.Add(lblPrice);
            pnlFormCard.Controls.Add(numPrice);
            pnlFormCard.Controls.Add(btnSave);
            pnlFormCard.Location = new Point(25, 75);
            pnlFormCard.Name = "pnlFormCard";
            pnlFormCard.Size = new Size(425, 250);
            pnlFormCard.TabIndex = 2;
            // 
            // pnlAuthorsCard
            // 
            pnlAuthorsCard.BackColor = Color.FromArgb(33, 37, 48);
            pnlAuthorsCard.Controls.Add(lblAuthors);
            pnlAuthorsCard.Controls.Add(clbAuthors);
            pnlAuthorsCard.Location = new Point(470, 75);
            pnlAuthorsCard.Name = "pnlAuthorsCard";
            pnlAuthorsCard.Size = new Size(450, 250);
            pnlAuthorsCard.TabIndex = 3;
            // 
            // FrmBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 36);
            ClientSize = new Size(950, 635);
            Controls.Add(pnlAuthorsCard);
            Controls.Add(pnlFormCard);
            Controls.Add(lblGridHeader);
            Controls.Add(gridBooks);
            Controls.Add(lblHeader);
            Controls.Add(nightControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ludibuks Ebook Library";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBooks).EndInit();
            pnlFormCard.ResumeLayout(false);
            pnlFormCard.PerformLayout();
            pnlAuthorsCard.ResumeLayout(false);
            pnlAuthorsCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NightControlBox nightControlBox1;
        private NightHeaderLabel lblHeader;
        private NightLabel lblTitle;
        private TextBox txtTitle;
        private NightLabel lblIsbn;
        private TextBox txtIsbn;
        private NightLabel lblPrice;
        private NumericUpDown numPrice;
        private System.Windows.Forms.Button btnSave;
        private NightLabel lblAuthors;
        private CheckedListBox clbAuthors;
        private DataGridView gridBooks;
        private NightLabel lblGridHeader;
        private System.Windows.Forms.Panel pnlFormCard;
        private ReaLTaiizor.Controls.Panel pnlAuthorsCard;
    }
}