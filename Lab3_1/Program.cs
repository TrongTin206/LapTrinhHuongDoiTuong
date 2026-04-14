using System;
using System.Collections.Generic; // Để dùng List
using System.Linq;               // Để dùng Min, Max, Where, OrderBy
namespace QuanLyXeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            do
            {
                Console.Write("Nhập số lượng xe con (0 < n < 50): ");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0 || n >= 50);
            List<XeCon> dsXe = new List<XeCon>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin xe thứ {i + 1} ");
                XeCon xe = new XeCon();
                xe.Nhap();
                dsXe.Add(xe);
            }
            Console.WriteLine("\n1. DANH SÁCH XE VỪA NHẬP ");
            foreach (XeCon x in dsXe)
            {
                x.Xuat();
            }
            double giaThapNhat = dsXe.Min(x => x.Gia);
            double giaCaoNhat = dsXe.Max(x => x.Gia);
            Console.WriteLine($"\n2. XE CÓ GIÁ THẤP NHẤT ({giaThapNhat} triệu) ");
            dsXe.Where(x => x.Gia == giaThapNhat).ToList().ForEach(x => x.Xuat());
            Console.WriteLine($"\n3. XE CÓ GIÁ CAO NHẤT ({giaCaoNhat} triệu) ");
            dsXe.Where(x => x.Gia == giaCaoNhat).ToList().ForEach(x => x.Xuat());
            Console.Write("\n4. Nhập 2 số đầu biển số cần tìm (vd: 79): ");
            string maTinh = Console.ReadLine();
            var danhSachTimDuoc = dsXe.Where(x => x.BienSo.StartsWith(maTinh)).ToList();

            if (danhSachTimDuoc.Count > 0)
            {
                danhSachTimDuoc.ForEach(x => x.Xuat());
            }
            else
            {
                Console.WriteLine("Không tìm thấy xe nào thuộc tỉnh này!");
            }
            Console.WriteLine("\n5. DANH SÁCH SAU KHI SẮP XẾP THEO NĂM SẢN XUẤT ");
            var dsSapXep = dsXe.OrderBy(x => x.NamSanXuat).ToList();
            foreach (var x in dsSapXep)
            {
                x.Xuat();
            }
            Console.ReadLine();
        }
    }
}