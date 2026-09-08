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
            gridBooks = new DataGridView();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtIsbn = new TextBox();
            label3 = new Label();
            numPrice = new NumericUpDown();
            btnSave = new Button();
            clbAuthors = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)gridBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // gridBooks
            // 
            gridBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBooks.Location = new Point(22, 163);
            gridBooks.Name = "gridBooks";
            gridBooks.RowHeadersWidth = 62;
            gridBooks.Size = new Size(391, 225);
            gridBooks.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(185, 22);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 2;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 62);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 4;
            label2.Text = "Isbn";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(185, 59);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(150, 31);
            txtIsbn.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 99);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 6;
            label3.Text = "Precio";
            // 
            // numPrice
            // 
            numPrice.Location = new Point(185, 104);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(180, 31);
            numPrice.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(657, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // clbAuthors
            // 
            clbAuthors.FormattingEnabled = true;
            clbAuthors.Location = new Point(454, 22);
            clbAuthors.Name = "clbAuthors";
            clbAuthors.Size = new Size(180, 368);
            clbAuthors.TabIndex = 9;
            // 
            // FrmBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clbAuthors);
            Controls.Add(btnSave);
            Controls.Add(numPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtIsbn);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(gridBooks);
            Name = "FrmBooks";
            Text = "FrmBooks";
            ((System.ComponentModel.ISupportInitialize)gridBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridBooks;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private TextBox txtIsbn;
        private Label label3;
        private NumericUpDown numPrice;
        private Button btnSave;
        private CheckedListBox clbAuthors;
    }
}