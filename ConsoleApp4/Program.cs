using System;
    using System.Collections.Generic;
    using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap So Luong Xe");
            int n = int.Parse(Console.ReadLine());

            XeCon[] xeCons = new XeCon[n];

            for (int i = 0; i < n; i++)
            {
                XeCon xc = new XeCon();
                xc.Nhap();
                xeCons[i] = xc;
            }

            for (int i = 0; i < n; i++)
            {
                xeCons[i].Xuat();
            }

            int minGiaXe = xeCons[0].GetGiaXe();
            for (int i = 0; i < n; i++)
            {
                if (xeCons[i].GetGiaXe() < minGiaXe)
                    minGiaXe = xeCons[i].GetGiaXe();
            }
            string timBS = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (xeCons[i].GetBienSo().StartsWith(timBS))
                {
                    xeCons[i].Xuat();
                }
            }
        }
    }
}


