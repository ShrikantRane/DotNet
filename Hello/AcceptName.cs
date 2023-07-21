using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class AcceptName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name Here:");
            String str= Console.ReadLine();
            Console.WriteLine("Welcome "+str);
        }
    }
}
