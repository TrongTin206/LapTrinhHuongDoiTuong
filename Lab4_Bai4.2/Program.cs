using Lab4_Bai4._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Bai42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so luong: ");
            int n = int.Parse(Console.ReadLine());

            Shape[] ds = new Shape[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nChon hinh: ");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Square");

                int chon = int.Parse(Console.ReadLine());
                Shape item;
                if (chon == 1)
                {
                    item = new Rectangle();
                }
                else if (chon == 2)
                {
                    item = new Circle();
                }
                else
                {
                    item = new Square();
                }
                item.Nhap();
                ds[i] = item;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{ds[i].Name}: \t {ds[i]. Area()}");
            }   

        }
    }
}
