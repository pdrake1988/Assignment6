using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Bank
{
    public class Customer
    {
        public Customer(int id, string name, string address, Account account, Bank bank)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Account = account;
            this.Bank = bank;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Account Account { get; set; }
        public Bank Bank { get; set; }
    }
}
