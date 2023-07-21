using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Value_Type
{
    struct Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public void Display()
        {
            Console.WriteLine($"{Id}--->{Name}--->{Price}");
        }
    }
    class BookDemo
    {
        static void Main1(string[] args)
        {
            Book book = new Book();
            //for (int i = 0; i < 3; i++)
            //{
                Console.WriteLine("Id:");
                book.Id= int.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                book.Name = Console.ReadLine();
                Console.WriteLine("Author:");
                book.Author = Console.ReadLine();
                Console.WriteLine("Price:");
                book.Price = float.Parse(Console.ReadLine());
            //}
            book.Display();
        }

    }
}
