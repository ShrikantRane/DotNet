using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Output
{
    internal class Tables
    {
        static void Main4(string[] args)
        {
            int n = 0;
            Console.WriteLine("Vertical Tables:-");
            for(int i = 1; i < 11; i++)
            {
                for(int j = 1; j < 13; j++)
                {
                    Console.Write(" "+i*j);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Horizontal Tables:-");
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write(" "+i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
