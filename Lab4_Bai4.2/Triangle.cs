using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4_Bai4._2
{
    internal class Triangle
    {
        public double width;
        public double height;

        public Triangle()
        {
        }

        public Triangle(string name, double w, double h) : base(name)
        {
            width = w;
            height = h;

        }

        public override void Nhap()
        {
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();

            Console.Write("Nhap dai: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Nhap rong: ");
            height = double.Parse(Console.ReadLine());
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
