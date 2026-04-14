using System;
using System.Collections.Generic;
using System.Linq;
namespace QuanLyMayIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số lượng máy in Laser (n): ");
            int n = int.Parse(Console.ReadLine());
            List<LaserPrinter> dsMayIn = new List<LaserPrinter>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin máy in thứ {i + 1}");
                LaserPrinter mayIn = new LaserPrinter();
                mayIn.Nhap();
                dsMayIn.Add(mayIn);
            }
            Console.WriteLine("\nDanh sách máy in vừa nhập là:");
            foreach (var may in dsMayIn)
            {
                may.Xuat();
            }
            if (dsMayIn.Count > 0)
            {
                double giaMin = dsMayIn.Min(x => x.GiaBan);
                double giaMax = dsMayIn.Max(x => x.GiaBan);
                Console.WriteLine($"\nMáy in có giá thấp nhất ({giaMin:N0} VNĐ) ");
                dsMayIn.Where(x => x.GiaBan == giaMin).ToList().ForEach(x => x.Xuat());
                Console.WriteLine($"\nMáy in có giá cao nhất ({giaMax:N0} VNĐ) ");
                dsMayIn.Where(x => x.GiaBan == giaMax).ToList().ForEach(x => x.Xuat());
                Console.Write("\nNhập tên hãng sản xuất cần lọc: ");
                string hangCanTim = Console.ReadLine();
                var dsLoc = dsMayIn.Where(x => x.NhaSanXuat.ToLower().Contains(hangCanTim.ToLower())).ToList();
                if (dsLoc.Count > 0)
                {
                    Console.WriteLine($"\nCác máy in thuộc hãng '{hangCanTim.ToUpper()}' ");
                    dsLoc.ForEach(x => x.Xuat());
                }
                else
                {
                    Console.WriteLine("\nKhông tìm thấy máy in nào của hãng này!");
                }
                Console.WriteLine("\nDanh sách sắp xếp giá tăng dần");
                var dsSapXep = dsMayIn.OrderBy(x => x.GiaBan).ToList();
                foreach (var may in dsSapXep)
                {
                    may.Xuat();
                }
            }
            Console.ReadLine();
        }
    }
}