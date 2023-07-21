using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Calculation
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
        public int Mul(int a,int b)
        {
            return a * b;
        }
    }
    public delegate int CalDel(int a,int b);
    class MyDemo
    {
        static void Main2(string[] args)
        {
            Calculation c = new Calculation();
            /*CalDel cd = new CalDel(c.Add);
            cd += c.Sub;
            cd += c.Mul;
            int res=cd(3, 2);
            Console.WriteLine(res);*/
            Func<int, int, int> f = c.Add;
            f += delegate (int a, int b)
            {
                return a * a * b;
            };
            int res = f(3, 2);
            Console.WriteLine(res);

        }
    }
}
