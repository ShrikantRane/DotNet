using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class SavingAccount : Account
    {
        static int int_rate { get; set; } = 8;
        public override int calBalance()
        {
            return balance * int_rate;
        }

        public override void withdraw(int amt)
        {

            if (balance > 2000)
            {
                balance = balance - amt;
                Console.WriteLine("Withdrawal sucessfull.");
            }
            else
                Console.WriteLine("Failed transaction");
        }
    }
}
