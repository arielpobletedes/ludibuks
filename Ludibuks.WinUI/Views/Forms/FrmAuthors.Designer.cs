using ReaLTaiizor.Controls;

namespace Ludibuks.WinUI.Views.Forms
{
    partial class FrmAuthors
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
            pnlAuthorForm = new System.Windows.Forms.Panel();
            btnClearForm = new System.Windows.Forms.Button();
            btnDeleteAuthor = new HopeButton();
            btnSaveAuthor = new HopeButton();
            txtBiography = new TextBox();
            lblBiography = new NightLabel();
            txtName = new TextBox();
            lblName = new NightLabel();
            pnlAuthorList = new System.Windows.Forms.Panel();
            gridAuthors = new DataGridView();
            lblListHeader = new NightLabel();
            pnlAuthorForm.SuspendLayout();
            pnlAuthorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAuthors).BeginInit();
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
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(710, 0);
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
            lblHeader.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(240, 240, 240);
            lblHeader.LeftSideForeColor = Color.FromArgb(250, 250, 250);
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.RightSideForeColor = Color.FromArgb(170, 171, 176);
            lblHeader.Side = NightHeaderLabel.PanelSide.LeftPanel;
            lblHeader.Size = new Size(298, 50);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Gestión de Autores";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            lblHeader.UseCompatibleTextRendering = true;
            // 
            // pnlAuthorForm
            // 
            pnlAuthorForm.BackColor = Color.FromArgb(33, 37, 48);
            pnlAuthorForm.Controls.Add(btnClearForm);
            pnlAuthorForm.Controls.Add(btnDeleteAuthor);
            pnlAuthorForm.Controls.Add(btnSaveAuthor);
            pnlAuthorForm.Controls.Add(txtBiography);
            pnlAuthorForm.Controls.Add(lblBiography);
            pnlAuthorForm.Controls.Add(txtName);
            pnlAuthorForm.Controls.Add(lblName);
            pnlAuthorForm.Location = new Point(20, 75);
            pnlAuthorForm.Name = "pnlAuthorForm";
            pnlAuthorForm.Size = new Size(360, 445);
            pnlAuthorForm.TabIndex = 2;
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
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.BackColor = Color.FromArgb(199, 80, 80);
            btnDeleteAuthor.BorderColor = Color.FromArgb(220, 223, 230);
            btnDeleteAuthor.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDeleteAuthor.DangerColor = Color.FromArgb(245, 108, 108);
            btnDeleteAuthor.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDeleteAuthor.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnDeleteAuthor.ForeColor = Color.White;
            btnDeleteAuthor.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnDeleteAuthor.InfoColor = Color.FromArgb(144, 147, 153);
            btnDeleteAuthor.Location = new Point(185, 330);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.PrimaryColor = Color.FromArgb(199, 80, 80);
            btnDeleteAuthor.Size = new Size(160, 42);
            btnDeleteAuthor.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDeleteAuthor.TabIndex = 5;
            btnDeleteAuthor.Text = "🗑️ Eliminar";
            btnDeleteAuthor.TextColor = Color.White;
            btnDeleteAuthor.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnSaveAuthor
            // 
            btnSaveAuthor.BackColor = Color.FromArgb(64, 158, 255);
            btnSaveAuthor.BorderColor = Color.FromArgb(220, 223, 230);
            btnSaveAuthor.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSaveAuthor.DangerColor = Color.FromArgb(245, 108, 108);
            btnSaveAuthor.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSaveAuthor.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSaveAuthor.ForeColor = Color.White;
            btnSaveAuthor.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSaveAuthor.InfoColor = Color.FromArgb(144, 147, 153);
            btnSaveAuthor.Location = new Point(15, 330);
            btnSaveAuthor.Name = "btnSaveAuthor";
            btnSaveAuthor.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnSaveAuthor.Size = new Size(160, 42);
            btnSaveAuthor.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSaveAuthor.TabIndex = 4;
            btnSaveAuthor.Text = "💾 Guardar";
            btnSaveAuthor.TextColor = Color.White;
            btnSaveAuthor.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // txtBiography
            // 
            txtBiography.BackColor = Color.FromArgb(43, 48, 62);
            txtBiography.BorderStyle = BorderStyle.FixedSingle;
            txtBiography.Font = new Font("Segoe UI", 9.5F);
            txtBiography.ForeColor = Color.FromArgb(230, 230, 230);
            txtBiography.Location = new Point(15, 125);
            txtBiography.Multiline = true;
            txtBiography.Name = "txtBiography";
            txtBiography.Size = new Size(330, 185);
            txtBiography.TabIndex = 3;
            // 
            // lblBiography
            // 
            lblBiography.AutoSize = true;
            lblBiography.BackColor = Color.Transparent;
            lblBiography.Font = new Font("Segoe UI", 9F);
            lblBiography.ForeColor = Color.FromArgb(180, 185, 200);
            lblBiography.Location = new Point(15, 95);
            lblBiography.Name = "lblBiography";
            lblBiography.Size = new Size(191, 25);
            lblBiography.TabIndex = 2;
            lblBiography.Text = "Biografía / Descripción";
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
            lblName.Size = new Size(170, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre del Autor *";
            // 
            // pnlAuthorList
            // 
            pnlAuthorList.BackColor = Color.FromArgb(33, 37, 48);
            pnlAuthorList.Controls.Add(gridAuthors);
            pnlAuthorList.Controls.Add(lblListHeader);
            pnlAuthorList.Location = new Point(400, 75);
            pnlAuthorList.Name = "pnlAuthorList";
            pnlAuthorList.Size = new Size(430, 445);
            pnlAuthorList.TabIndex = 3;
            // 
            // gridAuthors
            // 
            gridAuthors.AllowUserToAddRows = false;
            gridAuthors.AllowUserToDeleteRows = false;
            gridAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAuthors.BackgroundColor = Color.FromArgb(33, 37, 48);
            gridAuthors.BorderStyle = BorderStyle.None;
            gridAuthors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridAuthors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(200, 205, 220);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 28, 38);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridAuthors.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 37, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(220, 225, 235);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 65, 95);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridAuthors.DefaultCellStyle = dataGridViewCellStyle2;
            gridAuthors.EnableHeadersVisualStyles = false;
            gridAuthors.GridColor = Color.FromArgb(45, 50, 65);
            gridAuthors.Location = new Point(15, 45);
            gridAuthors.MultiSelect = false;
            gridAuthors.Name = "gridAuthors";
            gridAuthors.ReadOnly = true;
            gridAuthors.RowHeadersVisible = false;
            gridAuthors.RowHeadersWidth = 51;
            gridAuthors.RowTemplate.Height = 32;
            gridAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridAuthors.Size = new Size(400, 380);
            gridAuthors.TabIndex = 1;
            // 
            // lblListHeader
            // 
            lblListHeader.AutoSize = true;
            lblListHeader.BackColor = Color.Transparent;
            lblListHeader.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblListHeader.ForeColor = Color.FromArgb(220, 225, 235);
            lblListHeader.Location = new Point(15, 10);
            lblListHeader.Name = "lblListHeader";
            lblListHeader.Size = new Size(242, 30);
            lblListHeader.TabIndex = 0;
            lblListHeader.Text = "👥 Autores Registrados";
            // 
            // FrmAuthors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 36);
            ClientSize = new Size(850, 540);
            Controls.Add(pnlAuthorList);
            Controls.Add(pnlAuthorForm);
            Controls.Add(lblHeader);
            Controls.Add(nightControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAuthors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Autores - Ludibuks";
            pnlAuthorForm.ResumeLayout(false);
            pnlAuthorForm.PerformLayout();
            pnlAuthorList.ResumeLayout(false);
            pnlAuthorList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NightControlBox nightControlBox1;
        private NightHeaderLabel lblHeader;
        private System.Windows.Forms.Panel pnlAuthorForm;
        private NightLabel lblName;
        private TextBox txtName;
        private NightLabel lblBiography;
        private TextBox txtBiography;
        private HopeButton btnSaveAuthor;
        private HopeButton btnDeleteAuthor;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Panel pnlAuthorList;
        private NightLabel lblListHeader;
        private DataGridView gridAuthors;
    }
}
