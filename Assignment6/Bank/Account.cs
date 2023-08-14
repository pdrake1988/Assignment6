using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Bank
{
    public class Account
    {
        public Account(
            string name,
            int balance,
            Bank bank,
            int routingNumber,
            int accountNumber,
            int getBalance
        )
        {
            this.Name = name;
            this.Balance = balance;
            this.Bank = bank;
            this.RoutingNumber = routingNumber;
            this.AccountNumber = accountNumber;
        }

        public string Name { get; set; }
        public int Balance { get; set; }
        public Bank Bank { get; set; }
        public int RoutingNumber { get; set; }
        public int AccountNumber { get; set; }

        public void Deposit(int amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(int amount)
        {
            this.Balance -= amount;
        }

        public int GetBalance()
        {
            return this.Balance;
        }
    }
}
