using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.CarRental
{
    public class RentalCompany
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
        public List<Customer> Customers { get; set; }

        public void RentCar(Customer customer)
        {
            Cars.Remove(customer.Rental);
            Customers.Add(customer);
        }

        public void ReturnCar(Customer customer)
        {
            Customers.Remove(customer);
            Cars.Add(customer.Rental);
        }
    }
}
