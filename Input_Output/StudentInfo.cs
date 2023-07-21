using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Output
{
    internal class StudentInfo
    {
        static void Main2(string[] args)
        {
            int roll_no = 784;
            String name = "James";
            int physics = 70;
            int chemistry = 80;
            int computer = 90;
            int total=physics+chemistry+computer;
            float percentage =(total / 300.0f)*100.0f;
            String grade="First Class";

            Console.WriteLine("Roll No : "+roll_no);
            Console.WriteLine("Name Of Student : "+name);
            Console.WriteLine("Marks in Physics : "+physics);
            Console.WriteLine("Marks in Chemistry : "+chemistry);
            Console.WriteLine("Marks In Computer Application : "+computer);
            Console.WriteLine("Total Marks = "+total);
            Console.WriteLine("Percentage = "+percentage);
            Console.WriteLine("Class = "+grade);
        }
    }
}
