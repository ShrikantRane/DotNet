using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class MyNumber
    {
        public MyNumber()
        {
            No = 0;
        }

        private int No { get; set; }

        public MyNumber(int no)
        {
            this.No = no;
        }
        public void IsPositive()
        {
              Console.WriteLine($"{No} is positive number.");
        }
        public void IsNegative()
        {
            Console.WriteLine($"{No} is negative number.");
        }
        public void IsZero()
        {
            Console.WriteLine($"{No} is zero.");
        }
        public void IsEven()
        {
            Console.WriteLine($"{No} is even number.");
        }
        public void IsOdd()
        {
            Console.WriteLine($"{No} is odd number.");
        }
    }
    class MyNumberDemo
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int no = int.Parse(Console.ReadLine());
            MyNumber mn=new MyNumber(no);
            if (no > 0)
                mn.IsPositive();
            if (no < 0)
                mn.IsNegative();
            if (no == 0)
                mn.IsZero();
            if (no % 2 == 0)
                mn.IsEven();
            if (no % 2 == 1)
                mn.IsOdd();

        }
    }
}
