using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    partial class BankAccount
    {
        //Fields
        public int accountnumber = 1234;
        public string accountholdername = "John";
        public double currentbalance = 10000;

        //Deposit method
        public void Deposit(double amount)
        {
            currentbalance = currentbalance + amount;
        }
    }

    partial class BankAccount
    {
        //Withdraw method
        public void Withdraw(double amount)
        {
            currentbalance = currentbalance - amount;
        }
    }

}
