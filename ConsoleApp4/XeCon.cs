using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class XeCon : Xe
    {
        private int SoChoNgoi;
        private string LoaiXe;

        public XeCon()
        {

        }
        public XeCon(string bienSo, int namSX, int gia, int sc, string lx)
            : base(bienSo, namSX, gia)
        {
            SoChoNgoi = sc;
            LoaiXe = lx;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("So cho ngoi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap loai xe: ");
            LoaiXe = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So cho ngoi: {SoChoNgoi}");
            Console.WriteLine($"Loai xe: {LoaiXe}");
        }
    }
}
