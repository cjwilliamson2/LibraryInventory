using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInventory
{
    internal class Book
    {
        public Book() { }

        public Book(string author, string title, string isbn)
        {
            this.Author = author;
            this.Title = title;
            this.Isbn = isbn;
        }

        public string Author { get; set; }

        public string Title { get; set; }

        public string Isbn { get; set; }

        public string GetFormattedText()
        {
            return Title + " | " + Author + " | " + Isbn;
        }
    }
}
