using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4_Bai4._2
{
    internal class Circle : Shape
    {
        public double radius;

        public Circle()
        {
        }



        public Circle(string name, double r) : base(name)
        {
            radius = r;

        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override void Nhap()
        {
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();

            Console.Write("r= ");
            radius = double.Parse(Console.ReadLine());


        }

    }
}