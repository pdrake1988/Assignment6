using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Payroll
{
    public class Payroll
    {
        public List<Employee> Employees { get; set; }

        public float GetPayroll(string name)
        {
            Employee? empSalary = Employees.Find(e => e.Name == name);
            if (empSalary != null)
            {
                return empSalary.Salary;
            }
            else
            {
                return 0;
            }
        }
    }
}
