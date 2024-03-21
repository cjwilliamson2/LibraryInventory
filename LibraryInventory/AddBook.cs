using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryInventory
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Book b = new Book(txtAuthor.Text, txtTitle.Text, txtISBN.Text);

            this.DialogResult = DialogResult.OK;
            this.Tag = b;
            this.Close();
        }
    }
}
