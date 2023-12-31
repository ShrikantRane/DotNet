﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }  

        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"[{X},{Y}]");
        }
    }
    class PointDemo
    {
        static void Main3(string[] args)
        {
            Point point = new Point(3,4);
            point.Display();
        }
    }
}
