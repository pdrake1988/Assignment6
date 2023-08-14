using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Bank
{
    public class Checking : Account
    {
        public Checking(
            string name,
            int balance,
            Bank bank,
            int routingNumber,
            int accountNumber,
            int getBalance,
            int beginningBalance,
            int endingBalance,
            List<int> transactions
        )
            : base(name, balance, bank, routingNumber, accountNumber, getBalance)
        {
            this.BeginningBalance = beginningBalance;
            this.EndingBalance = endingBalance;
            this.Transactions = transactions;
        }

        public int BeginningBalance { get; set; }
        public int EndingBalance { get; set; }
        public List<int> Transactions { get; set; }
    }
}
