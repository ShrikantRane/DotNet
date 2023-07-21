using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class MyNumber : IintOperation
    {
        public double calFactorial(int num)
        {
            int a = 1;
            for(int i = 1; i <= num; i++)
            {
                a = a * i;
            }
            return a;
        }

        public Boolean isEven(int num)
        {
           if(num%2==0)
                return true;
           else
                return false;
        }

        public bool isOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            else
                return false ;
                
        }

        public bool isPrime(int num)
        {
            Boolean flag = true;
            for(int i=2;i<num;i++)
            {
                if(num%i==0) { flag = false; break; }
            }
            if (flag == true)
                return true;
            else
                return false;
        }
    }
}
