using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
   
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine(account.currentbalance);

            //Deposit
            account.Deposit(5000);
            Console.WriteLine("After Deposit CurrentBalance: " + account.currentbalance);

            //Withdrawl
            account.Withdraw(2000);
            Console.WriteLine("After Widthdrawl CurrentBalance:" + account.currentbalance);
            Console.ReadKey();

        }
    }
}
