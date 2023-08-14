using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Employee
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public float Salary { get; set; }
        public List<Worker> Employees { get; set; }
    }
}
