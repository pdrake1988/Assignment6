using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Library
{
    public class Borrower
    {
        public Borrower(string name, int age, string address, string gender, Book book)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Gender = gender;
            Book = book;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public Book Book { get; set; }
    }
}
