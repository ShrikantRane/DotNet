using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Calculator
    {
        /*public Calculator()
        {
        }*/

        public int no1 { get; set; }
        public int no2 { get; set; }

        public Calculator(int no1, int no2)
        {
            this.no1 = no1;
            this.no2 = no2;
        }

        public void Add()
        {
            Console.WriteLine(no1+no2);
        }
        public void Sub()
        {
            Console.WriteLine(no1 - no2);
        }
        public void Mul()
        {
            Console.WriteLine(no1 * no2);
        }
        public void Div()
        {
            Console.WriteLine(no1 / no2);
        }
    }

    class CalculatorDemo
    {
        static void Main1(string[] args)
        {
            Calculator c=new Calculator(8,4);
            Console.Write("Addition:-->");
            c.Add();
            Console.Write("Substraction:-->");
            c.Sub();
            Console.Write("Multiplication:-->");
            c.Mul();
            Console.Write("Division:-->");
            c.Div();
        }
    }
}
