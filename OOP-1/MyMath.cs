using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class MyMath
    {
        public void Add(int a,int b)
        {
            Console.WriteLine($"Sum of two integers: {a}+{b} = "+(a+b));
        }
        public void Add(int a,int b,int c)
        {
            Console.WriteLine($"Sum of three integers: {a}+{b}+{c} = "+(a+b+c));
        }
        public void Add(float a,float b)
        {
            Console.WriteLine($"Sum of two floats: {a}+{b} = "+(a+b));
        }
    }
    class MyMathDemo
    {
        static void Main1(string[] args)
        {
            MyMath  m= new MyMath();
            m.Add(2, 3);
            m.Add(b:2, a:4, c:5);
            m.Add(12.0f, 34.2f);

        }
    }
}
