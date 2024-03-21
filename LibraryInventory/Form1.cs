namespace LibraryInventory
{
    public partial class frmLibraryInventory : Form
    {
        public frmLibraryInventory()
        {
            InitializeComponent();
        }

        private Inventory inv = new Inventory();

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook newBookForm = new AddBook();
            DialogResult = newBookForm.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                inv = inv + (Book)newBookForm.Tag;
                FillBookListBox();
            }
        }

        private void frmLibraryInventory_Load(object sender, EventArgs e)
        {
            FillBookListBox();
        }

        private void FillBookListBox()
        {
            Book b;
            lstBooks.Items.Clear();
            for (int i = 0; i < inv.Count; i++)
            {
                b = inv[i];
                lstBooks.Items.Add(b.GetFormattedText());
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem != null) {
                string tmp = (string)lstBooks.SelectedItem;
                string[] tmpArray = tmp.Split();
                tmp = tmpArray[tmpArray.Length - 1];
                
                Book b = inv[tmp];
                inv -= b;
                FillBookListBox();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}