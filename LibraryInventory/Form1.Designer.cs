namespace LibraryInventory
{
    partial class frmLibraryInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstBooks = new ListBox();
            btnAddBook = new Button();
            btnDeleteBook = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 15;
            lstBooks.Location = new Point(48, 48);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(273, 154);
            lstBooks.TabIndex = 0;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddBook.Location = new Point(369, 48);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(83, 23);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(369, 114);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(83, 23);
            btnDeleteBook.TabIndex = 2;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(369, 179);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLibraryInventory
            // 
            AcceptButton = btnAddBook;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(488, 265);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnAddBook);
            Controls.Add(lstBooks);
            Name = "frmLibraryInventory";
            Text = "Library Inventory";
            Load += frmLibraryInventory_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstBooks;
        private Button btnAddBook;
        private Button btnDeleteBook;
        private Button btnExit;
    }
}