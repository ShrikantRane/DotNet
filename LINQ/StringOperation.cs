using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class StringOperation
    {
        static void Main1(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("orange");
            list.Add("cheery");
            list.Add("banana");
            list.Add("strowberry");
            list.Add("mango");
            list.Add("fig");
            Console.WriteLine("===Count===");
            var result = (from s in list
                         select s).Count();
            Console.WriteLine(result);
            Console.WriteLine("===Length greater than 3===");
            var res1=from s in list
                     where s.Length>3
                     select s;
            foreach (var item in res1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===Length between 4 & 7 ===");
            var res2 = from s in list
                       where s.Length >= 4 && s.Length <= 7
                       select s;
            foreach (var item in res2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===Ascending Order ===");
            var res3=from s in list
                     orderby s
                     select s;
            foreach (var item in res3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===Descending Order ===");
            var res4 = from s in list
                       orderby s descending
                       select s;
            foreach (var item in res4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===Length greater than 5===");
            var res5 = from s in list
                       where s.Length > 5
                       select s;
            foreach (var item in res5)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===Starts with 'm'==");
            var res6=from s in list
                     where s.StartsWith('m')
                     select s;
            foreach (var item in res6)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===Ends with 'rry'==");
            var res7 = from s in list
                       where s.EndsWith("rry")
                       select s;
            foreach (var item in res7)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
