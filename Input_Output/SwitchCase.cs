using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Output
{
    internal class SwitchCase
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Enter Month:");
            int mm = int.Parse(Console.ReadLine());
            switch(mm)
            {
                case 1: Console.WriteLine("Jan");break;
                case 2: Console.WriteLine("Feb");break;
                case 3: Console.WriteLine("Mar");break;
                case 4: Console.WriteLine("Apr"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("June"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("Aug"); break;
                case 9: Console.WriteLine("Sep"); break;
                case 10: Console.WriteLine("Oct"); break;
                case 11: Console.WriteLine("Nov"); break;
                case 12: Console.WriteLine("Dec"); break;
                default: Console.WriteLine("Invalid Entry");break;
            }
        }
    }
}
