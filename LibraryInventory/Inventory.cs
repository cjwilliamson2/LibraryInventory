using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInventory
{
    internal class Inventory
    {
        private List<Book> books;

        public Inventory() {
            books = new();
        }

        public int Count => books.Count;

        public Book this[int i]
        {
            get
            {
                if (i < 0 || i > Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }

                return books[i];
            }
        }

        public Book this[string s]
        {
            get
            {
                foreach (Book book in books)
                {
                    if (s == book.Isbn) return book;
                }

                throw new Exception(s.ToString());
            }
        }

        public void Add(Book b)
        {
            books.Add(b);
        }

        public void Remove(Book b)
        {
            books.Remove(b); 
            //TODO: Trigger an event to notify librarian
        }

        public static Inventory operator + (Inventory inv, Book b)
        {
            inv.Add(b);
            return inv;
        }

        public static Inventory operator - (Inventory inv, Book b)
        {
            inv.Remove(b);
            return inv;
        }

    }
}

