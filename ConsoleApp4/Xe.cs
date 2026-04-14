using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Xe
    {
        protected string BienSo;
        protected int NamSX;
        protected int Gia;

        public int GetGiaXe()
        {
            return Gia;
        }

        public string GetBienSo()
        {
            return BienSo;
        }
        public Xe()
        {
        }
        public Xe(string bienSo, int namSX, int gia)
        {
            BienSo = bienSo;
            NamSX = namSX;
            Gia = gia;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap bien so: ");
            BienSo = Console.ReadLine();
            Console.Write("Nhap nam sx: ");
            NamSX = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia: ");
            Gia = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Bien so: {BienSo}");
            Console.WriteLine($"Nam sx: {NamSX}");
            Console.WriteLine($"Gia: {Gia}");
        }
    }
}
