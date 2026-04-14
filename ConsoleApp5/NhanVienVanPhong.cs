using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class NhanVienVP : NhanVien
    {
        public double LuongCanBan { get; set; }
        public int SoSanPham { get; set; }

        public NhanVienVP() : base() { }

        public override void Nhap()
        {
            Console.WriteLine("--- Nhập thông tin Nhân viên Sản xuất ---");
            base.Nhap();

            Console.Write("Nhập lương căn bản: ");
            LuongCanBan = double.Parse(Console.ReadLine());

            Console.Write("Nhập số sản phẩm: ");
            SoSanPham = int.Parse(Console.ReadLine());

            // THUẬT TOÁN TÍNH LƯƠNG
            Luong = LuongCanBan + (SoSanPham * 5000);
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" | Loại: Sản Xuất  | Lương CB: {LuongCanBan} | Số SP: {SoSanPham}");
        }
    }
}