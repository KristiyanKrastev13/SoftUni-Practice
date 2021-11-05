using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw()
        {
            Console.WriteLine(new string('*', this.Width * 2));
            for (int i = 0; i < this.Height - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', this.Width * 2 - 2) + "*");
            }

            Console.WriteLine(new string('*', this.Width * 2));
        }
    }
}
