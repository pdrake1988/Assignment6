using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.CarRental
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string LicenseNumber { get; set; }
        public Car Rental { get; set; }
    }
}
