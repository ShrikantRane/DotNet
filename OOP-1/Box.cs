using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Box
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public Box() { }
        public Box(int height, int width, int depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }
        public Box(Box b)
        {
            this.Height = b.Height;
            this.Width = b.Width;
            this.Depth = b.Depth;
        }
        public int Area()
        {
            return Height * Width* Depth;
        }
    }
   

   
}
