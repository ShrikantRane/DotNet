using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Date
    {
        public string Dd { get; set; } = "01";
        public string Mm { get; set; } = "01";
        public string Yy { get; set; } = "0001";

        public Date()
        {
            
        }
        public Date(string dd, string mm, string yy)
        {
            Dd = dd;
            Mm = mm;
            Yy = yy;
        }
        

        public string ShowDate()
        {
               return Dd + ":" + Mm + ":" + Yy;
        }
        public string ShowDate(string dd)
        {
            return dd + ":" + Mm + ":" + Yy;
        }
    }
    class DateDemo
    {
        static void Main1(string[] args)
        {
            Date d = new Date("23","12","1999");
            Console.WriteLine(d.ShowDate("22"));
        }
    }
}
