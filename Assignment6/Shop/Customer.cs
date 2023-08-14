using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Shop
{
    public class Customer
    {
        public Customer(
            int id,
            string name,
            string address,
            string city,
            string region,
            string postalCode,
            string country,
            string phone,
            Product product
        )
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.Region = region;
            this.PostalCode = postalCode;
            this.Country = country;
            this.Phone = phone;
            this.Product = product;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public Product Product { get; set; }
    }
}
