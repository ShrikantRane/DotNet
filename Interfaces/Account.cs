using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Account
    {
        public Account()
        {
        }

        public int accno { get; set; }
        public string name { get; set; }

        public int balance { get; set; }

        public Account(int accno, string name, int balance)
        {
            this.accno = accno;
            this.name = name;
            this.balance = balance;
        }
        public abstract void withdraw(int amt);

        public abstract int calBalance();

    }
}
