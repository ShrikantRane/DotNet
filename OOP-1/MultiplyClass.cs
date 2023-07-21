using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class MultiplyClass
    {
        public int Multiply(int a,int b,int c)
        {
            return a * b * c;
        }

        public int Multiply1(params int []arr)
        {
            int m = 1;
            foreach (int i in arr)
            {
                m=m*i;
            }
            return m;
        }
    }
}
