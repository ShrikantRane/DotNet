using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Output
{
    internal class Pallindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            int n1 = n;
            int rev = 0;
            int rem = 0;
            while(n1>0)
            {
                rem = n1 % 10;
                rev = rev * 10+rem;
                n1=n1/10;
            }
            if(n==rev)
            {
                Console.WriteLine("Pallindrome");
            }
            else
            {
                Console.WriteLine("Not Pallindrome");
            }
        }
    }
}
