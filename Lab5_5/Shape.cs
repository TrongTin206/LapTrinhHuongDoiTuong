using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_5
{
    abstract class Shape
    {
        public string Name;

        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area();
    }
   class ShapeRectangle : Shape
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;


        public ShapeRectangle() : base(" Rectangle")
        {

        }
        public ShapeRectangle(int x, int y, int width, int height) : base("Rectangle")
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return (Width * Height);
        }
    }
    class ShapeEllipse : Shape
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;

        public ShapeEllipse() : base("ShapeEllipse")
        {

        }

        public ShapeEllipse(int x, int y, int width, int height) : base("ShapeEllipse")
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Math.PI * (Width / 2 ) * ( Height/2);
        }
    }

}
