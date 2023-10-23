using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Account
    {
        //Attributes
        private string customerName;
        private string accountNumber;
        private decimal balance;

        //Methods

        public void make_deposit (decimal amount)
        {
        balance = balance + amount;


        }
        public void make_withdraw (decimal amount)
        { 
        balance = balance - amount;
        }

        public decimal getBalance()
        {
            return balance;
        }
    }
}
