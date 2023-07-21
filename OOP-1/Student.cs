using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Student
    {
        public Student()
        {
        }

        public int Id { get; set; }
        public float Percentage { get; set; }

        public Student(int id, float percentage)
        {
            Id = id;
            Percentage = percentage;
        }

        public String Grade()
        {
            String grade = "";
            if (Percentage >= 90)
                grade = "Excellent";
            else if (Percentage >= 80 && Percentage < 90)
                grade = "Very Good";
            else if (Percentage >= 70 && Percentage < 80)
                grade = "Good";
            else if (Percentage >= 60 && Percentage < 70)
                grade = "Average";
            else if (Percentage >= 40 && Percentage < 60)
                grade = "Pass";
            else
                grade = "Fail";
            return grade;
        }
    }
    class StudentDemo
    {
        static void Main1(string[] args)
        {
            Student s=new Student();
            s.Id =int.Parse(Console.ReadLine());
            s.Percentage =float.Parse(Console.ReadLine());
            Console.WriteLine(s.Grade());
        }
    }
}
