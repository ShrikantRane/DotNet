using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Student
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public override string? ToString()
        {
            return $"{No}-->{Name}--{Language}--{Age}--{City}";
        }
    }
    class PersonDemo
    {
        static void Main(string[] args)
        {
            List<Student> slist = new List<Student>
            {
                new Student{No=123,Name="Arun",Language="C#",Age=23,City="Pune"},
                new Student{No=124,Name="Alshay",Language="C#",Age=20,City="Pune"},
                new Student{No=125,Name="Rama",Language="C#",Age=22,City="Nashik"},
                new Student{No=126,Name="Riya",Language="C#",Age=25,City="Nagar"},
                new Student{No=127,Name="Amar",Language="Java",Age=20,City="Pune"},
                new Student{No=128,Name="Vidhya",Language="VB",Age=23,City="Nashik"},
                new Student{No=129,Name="Prajacta",Language="Java",Age=25,City="Nagar"},
            };
            Console.WriteLine("=====City Is Pune=====");
            var res1 = from s in slist
                       where s.City.Equals("Pune")
                       select s;
            foreach (var item in res1)
            {
                Console.WriteLine(item+" ");
            }
            Console.WriteLine();

            Console.WriteLine("=====Average of Age======");
            var res2 = (from s in slist
                       select s.Age).Average();
            Console.WriteLine(res2);
            Console.WriteLine();

            Console.WriteLine("=====Name Contains 'y'=====");
            var res3 = from s in slist
                       where s.Name.Contains('y')
                       select s;
            foreach (var item in res3)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("=====First Record=====");
            var res4 = (from s in slist
                       select s.Name).First();
            Console.WriteLine(res4);
            Console.WriteLine();

            Console.WriteLine("=====Last Record=====");
            var res5 = (from s in slist
                        select s.Name).Last();
            Console.WriteLine(res5);
            Console.WriteLine();

            Console.WriteLine("=====Ascending Names======");
            var res6 = from s in slist
                        orderby s.Name
                        select s;
            foreach (var item in res6)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("=====Descending Names======");
            var res7 = from s in slist
                       orderby s.Name descending
                       select s;
            foreach (var item in res7)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("=====Group By City======");
            var res8 = from s in slist
                       group s by s.City;      
            foreach (var item in res8)
            {
                foreach (var p in item)
                {
                    Console.WriteLine(p.Name+"--->"+p.City);
                }
            }
            Console.WriteLine();

            Console.WriteLine("=====Max Age======");
            var res9 = (from s in slist
                        select s.Age).Max();
            Console.WriteLine(res9);
            Console.WriteLine();

            Console.WriteLine("=====Min Age======");
            var res10 = (from s in slist
                        select s.Age).Min();
            Console.WriteLine(res10);
            Console.WriteLine();

            Console.WriteLine("=====No Of Students======");
            var res11 = (from s in slist
                        select s.Name).Count();
            Console.WriteLine(res11);
            Console.WriteLine();

            Console.WriteLine("=====No Of Students From Pune======");
            var res12 = (from s in slist
                         where s.City.Equals("Pune")
                         select s.City).Count();
            Console.WriteLine(res12);
            Console.WriteLine();
        }

       
    }
}
