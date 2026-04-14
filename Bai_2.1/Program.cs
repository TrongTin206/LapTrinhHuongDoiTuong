using System;

namespace Bai2_4
{
    public class Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }
    }
    public class Circle
    {
        public double r;
        public Point c;
        public Circle(double r, double x, double y)
        {
            this.r = r;
            c = new Point(x, y);
        }
        public double Area()
        {
            return Math.PI * r * r;
        }
        public void Move(double dx, double dy)
        {
            c.Move(dx, dy);
        }
        public void Xuat()
        {
            Console.WriteLine("Tam: (" + c.x + ", " + c.y + ")");
            Console.WriteLine("Ban kinh: " + r);
            Console.WriteLine("Dien tich: " + Area());
        }

    } // End of Circle class


    // Main program 
    class Program
    {
        static void Main()
        {
            Circle h1 = new Circle(3, 2, 4);
            Circle h2 = new Circle(5, 1, 1);

            Console.WriteLine("Hinh tron 1:");
            h1.Xuat();

            Console.WriteLine("\nHinh tron 2:");
            h2.Xuat();

            Console.WriteLine("\nDi chuyen hinh tron 1 (dx=2, dy=3)");
            h1.Move(2, 3);

            Console.WriteLine("Sau khi di chuyen:");
            h1.Xuat();
        }
    } // End of class Program
}