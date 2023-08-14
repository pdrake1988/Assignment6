using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Bank
{
    public class Bank
    {
        public Bank(
            string name,
            string address,
            int size,
            List<string> departments,
            List<string> officers
        )
        {
            this.Name = name;
            this.Address = address;
            this.Size = size;
            this.Departments = departments;
            this.Officers = officers;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Size { get; set; }
        public List<string> Departments { get; set; }
        public List<string> Officers { get; set; }
    }
}
