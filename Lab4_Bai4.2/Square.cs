using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Bai4._2
{
    internal class Square : Rectangle
    {
        public override void Nhap()
        {
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();

            Console.Write("Nhap dai: ");
            double w = double.Parse(Console.ReadLine());

            width = height = w;
        }
    }
}
