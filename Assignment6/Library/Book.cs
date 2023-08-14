using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Library
{
    public class Book
    {
        public Book(string title, string description, string author, int pages)
        {
            this.Title = title;
            this.Description = description;
            this.Author = author;
            this.Pages = pages;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}
