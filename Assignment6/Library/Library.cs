using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Library
{
    public static class Library
    {
        public static List<Book> Books = new List<Book>();
        public static List<Borrower> Borrowers = new List<Borrower>();

        public static void AddBook(Book book)
        {
            Books.Add(book);
        }

        public static void RentBook(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }
    }
}
