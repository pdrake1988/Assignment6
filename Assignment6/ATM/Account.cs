using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.ATM
{
    public class Account
    {
        public Account(int accountNumber, float balance, string type)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Type = type;
        }

        public int AccountNumber { get; set; }
        public float Balance { get; set; }
        public string Type { get; set; }
    }
}
