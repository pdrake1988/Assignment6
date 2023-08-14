using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Employee
{
    public interface IEmployee
    {
        string Name { get; set; }
        int Age { get; set; }
        string Role { get; set; }
        string Address { get; set; }
        string City { get; set; }
        float Salary { get; set; }
    }
}
