using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class IndexerExample
    {
        public int[] numbers;
        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }
    }
    class IndexerExampleDemo
    {
        static void Main1(string[] args)
        {
            IndexerExample demo = new IndexerExample();
            demo.numbers = new int[10];
            demo.numbers[0] = 1;
            demo.numbers[1] = 2;
            demo.numbers[2] = 3;
            demo.numbers[3] = 4;
            demo.numbers[4] = 5;
            demo.numbers[5] = 6;
            demo.numbers[6] = 7;
            demo.numbers[7] = 8;
            demo.numbers[8] = 9;
            demo.numbers[9] = 10;
            Console.WriteLine(demo.numbers[0]);
            Console.WriteLine(demo.numbers[1]);
            Console.WriteLine(demo.numbers[2]);
            Console.WriteLine(demo.numbers[3]);
            Console.WriteLine(demo.numbers[4]);
            Console.WriteLine(demo.numbers[5]);
            Console.WriteLine(demo.numbers[6]);
            Console.WriteLine(demo.numbers[7]);
            Console.WriteLine(demo.numbers[8]);
            Console.WriteLine(demo.numbers[9]);

        }
    }
}
