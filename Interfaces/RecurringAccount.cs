using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class RecurringAccount : Account
    {
        public int installment { get; set; } = 12;
        static int int_rate { get; set; } = 4;

        static int no_days { get; set; }
        public override int calBalance()
        {
            return ((balance * int_rate) / installment);
        }

        public override void withdraw(int amt)
        {
            Console.WriteLine("Withdrawal is not allowed.");
        }
    }
}
