using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Value_Type
{
    enum Month
    {
        January,
        Feb,
        Mar,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    enum Week
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class MyDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Month.January);
            Console.WriteLine((int)Month.January);
            Console.WriteLine(Month.Feb);
            Console.WriteLine((int)Month.Mar);
            Console.WriteLine(Month.April);
            Console.WriteLine((int)Month.May);
            Console.WriteLine(Month.June);
            Console.WriteLine((int)Week.Friday);
        }
    }
}
