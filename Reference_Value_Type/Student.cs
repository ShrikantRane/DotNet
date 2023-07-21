using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Value_Type
{
    struct Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }

        public Student(int id, string name, string email, int mark1, int mark2, int mark3)
        {
            Id = id;
            Name = name;
            Email = email;
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }
        public void Display()
        {
            Console.WriteLine($"{Id}:{Name}:{Email}:{Mark1}:{Mark2}:{Mark3}");
        }
    }
    class StudentDemo
    {
        static void Main1(string[] args)
        {
            Student s=new Student();
            Console.WriteLine("Id:");
            s.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name:");
            s.Name = Console.ReadLine();
            Console.WriteLine("Email:");
            s.Email = Console.ReadLine();
            Console.WriteLine("Mark 1:");
            s.Mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mark 2:");
            s.Mark2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mark 3:");
            s.Mark3 = int.Parse(Console.ReadLine());

            s.Display();

        }
    }
}
