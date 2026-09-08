using ReaLTaiizor.Controls;

namespace Ludibuks.WinUI.Views.Forms
{
    partial class FrmGenres
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
            pnlGenreForm = new System.Windows.Forms.Panel();
            btnClearForm = new System.Windows.Forms.Button();
            btnDeleteGenre = new HopeButton();
            btnSaveGenre = new HopeButton();
            txtName = new TextBox();
            lblName = new NightLabel();
            lblHeader = new NightHeaderLabel();
            pnlGenreList = new System.Windows.Forms.Panel();
            gridGenres = new DataGridView();
            lblListHeader = new NightLabel();
            nightControlBox1 = new NightControlBox();
            pnlGenreForm.SuspendLayout();
            pnlGenreList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridGenres).BeginInit();
            SuspendLayout();
            // 
            // pnlGenreForm
            // 
            pnlGenreForm.BackColor = Color.FromArgb(33, 37, 48);
            pnlGenreForm.Controls.Add(btnClearForm);
            pnlGenreForm.Controls.Add(btnDeleteGenre);
            pnlGenreForm.Controls.Add(btnSaveGenre);
            pnlGenreForm.Controls.Add(txtName);
            pnlGenreForm.Controls.Add(lblName);
            pnlGenreForm.Location = new Point(22, 83);
            pnlGenreForm.Name = "pnlGenreForm";
            pnlGenreForm.Size = new Size(360, 445);
            pnlGenreForm.TabIndex = 3;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.FromArgb(43, 48, 62);
            btnClearForm.FlatAppearance.BorderSize = 0;
            btnClearForm.FlatStyle = FlatStyle.Flat;
            btnClearForm.Font = new Font("Segoe UI", 9F);
            btnClearForm.ForeColor = Color.FromArgb(200, 205, 220);
            btnClearForm.Location = new Point(15, 385);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(330, 38);
            btnClearForm.TabIndex = 6;
            btnClearForm.Text = "\U0001f9f9 Limpiar Campos";
            btnClearForm.UseVisualStyleBackColor = false;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.BackColor = Color.FromArgb(199, 80, 80);
            btnDeleteGenre.BorderColor = Color.FromArgb(220, 223, 230);
            btnDeleteGenre.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDeleteGenre.DangerColor = Color.FromArgb(245, 108, 108);
            btnDeleteGenre.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDeleteGenre.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnDeleteGenre.ForeColor = Color.White;
            btnDeleteGenre.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnDeleteGenre.InfoColor = Color.FromArgb(144, 147, 153);
            btnDeleteGenre.Location = new Point(185, 330);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.PrimaryColor = Color.FromArgb(199, 80, 80);
            btnDeleteGenre.Size = new Size(160, 42);
            btnDeleteGenre.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDeleteGenre.TabIndex = 5;
            btnDeleteGenre.Text = "🗑️ Eliminar";
            btnDeleteGenre.TextColor = Color.White;
            btnDeleteGenre.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnSaveGenre
            // 
            btnSaveGenre.BackColor = Color.FromArgb(64, 158, 255);
            btnSaveGenre.BorderColor = Color.FromArgb(220, 223, 230);
            btnSaveGenre.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSaveGenre.DangerColor = Color.FromArgb(245, 108, 108);
            btnSaveGenre.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSaveGenre.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSaveGenre.ForeColor = Color.White;
            btnSaveGenre.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSaveGenre.InfoColor = Color.FromArgb(144, 147, 153);
            btnSaveGenre.Location = new Point(15, 330);
            btnSaveGenre.Name = "btnSaveGenre";
            btnSaveGenre.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSaveGenre.Size = new Size(160, 42);
            btnSaveGenre.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSaveGenre.TabIndex = 4;
            btnSaveGenre.Text = "💾 Guardar";
            btnSaveGenre.TextColor = Color.White;
            btnSaveGenre.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(43, 48, 62);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.ForeColor = Color.FromArgb(230, 230, 230);
            txtName.Location = new Point(15, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 33);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.ForeColor = Color.FromArgb(180, 185, 200);
            lblName.Location = new Point(15, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(182, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre del Género *";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(250, 250, 250);
            lblHeader.LeftSideForeColor = Color.FromArgb(250, 250, 250);
            lblHeader.Location = new Point(25, 30);
            lblHeader.Name = "lblHeader";
            lblHeader.RightSideForeColor = Color.FromArgb(170, 171, 176);
            lblHeader.Side = NightHeaderLabel.PanelSide.LeftPanel;
            lblHeader.Size = new Size(304, 50);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "Gestión de Géneros";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            lblHeader.UseCompatibleTextRendering = true;
            // 
            // pnlGenreList
            // 
            pnlGenreList.BackColor = Color.FromArgb(33, 37, 48);
            pnlGenreList.Controls.Add(gridGenres);
            pnlGenreList.Controls.Add(lblListHeader);
            pnlGenreList.Location = new Point(409, 83);
            pnlGenreList.Name = "pnlGenreList";
            pnlGenreList.Size = new Size(430, 445);
            pnlGenreList.TabIndex = 5;
            // 
            // gridGenres
            // 
            gridGenres.AllowUserToAddRows = false;
            gridGenres.AllowUserToDeleteRows = false;
            gridGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridGenres.BackgroundColor = Color.FromArgb(33, 37, 48);
            gridGenres.BorderStyle = BorderStyle.None;
            gridGenres.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridGenres.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(200, 205, 220);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 28, 38);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridGenres.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 37, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(220, 225, 235);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 65, 95);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridGenres.DefaultCellStyle = dataGridViewCellStyle2;
            gridGenres.EnableHeadersVisualStyles = false;
            gridGenres.GridColor = Color.FromArgb(45, 50, 65);
            gridGenres.Location = new Point(15, 45);
            gridGenres.MultiSelect = false;
            gridGenres.Name = "gridGenres";
            gridGenres.ReadOnly = true;
            gridGenres.RowHeadersVisible = false;
            gridGenres.RowHeadersWidth = 51;
            gridGenres.RowTemplate.Height = 32;
            gridGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridGenres.Size = new Size(400, 380);
            gridGenres.TabIndex = 1;
            // 
            // lblListHeader
            // 
            lblListHeader.AutoSize = true;
            lblListHeader.BackColor = Color.Transparent;
            lblListHeader.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblListHeader.ForeColor = Color.FromArgb(220, 225, 235);
            lblListHeader.Location = new Point(15, 10);
            lblListHeader.Name = "lblListHeader";
            lblListHeader.Size = new Size(246, 30);
            lblListHeader.TabIndex = 0;
            lblListHeader.Text = "👥 Géneros Registrados";
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
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(700, 12);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 6;
            // 
            // FrmGenres
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 36);
            ClientSize = new Size(855, 545);
            Controls.Add(nightControlBox1);
            Controls.Add(pnlGenreList);
            Controls.Add(pnlGenreForm);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGenres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Géneros - Ludibuks";
            pnlGenreForm.ResumeLayout(false);
            pnlGenreForm.PerformLayout();
            pnlGenreList.ResumeLayout(false);
            pnlGenreList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridGenres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlGenreForm;
        private System.Windows.Forms.Button btnClearForm;
        private HopeButton btnDeleteGenre;
        private HopeButton btnSaveGenre;
        private TextBox txtName;
        private NightLabel lblName;
        private NightHeaderLabel lblHeader;
        private System.Windows.Forms.Panel pnlGenreList;
        private DataGridView gridGenres;
        private NightLabel lblListHeader;
        private NightControlBox nightControlBox1;
    }
}