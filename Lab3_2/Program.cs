using System;
using System.Collections.Generic;
using System.Linq; // Thư viện chứa thuật toán sắp xếp
namespace QuanLyNhanVienOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhập số lượng nhân viên công ty: ");
            n = int.Parse(Console.ReadLine());

            // 1. TÍNH ĐA HÌNH (Polymorphism): 
            // Tạo 1 danh sách kiểu cha (NhanVien) nhưng có thể chứa được cả 2 loại con (VanPhong và SanXuat)
            List<NhanVien> dsNhanVien = new List<NhanVien>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhân viên thứ {i + 1} là loại nào?");
                Console.WriteLine("1. Nhân viên Văn Phòng");
                Console.WriteLine("2. Nhân viên Sản Xuất");
                Console.Write("Chọn (1 hoặc 2): ");
                int loai = int.Parse(Console.ReadLine());
                // Khai báo 1 biến kiểu Lớp Cha (nv)
                NhanVien nv;
                if (loai == 1)
                {
                    // Nhưng lại 'new' Lớp Con Văn Phòng
                    nv = new NhanVienVanPhong();
                }
                else
                {
                    // Hoặc 'new' Lớp Con Sản Xuất
                    nv = new NhanVienSanXuat();
                }
                // Dù nv đang giữ bản thể nào, khi gọi Nhap(), nó sẽ tự biết chạy vào đúng hàm Nhap() của bản thể đó.
                nv.Nhap();
                dsNhanVien.Add(nv); // Cất vào chung 1 kho
            }
            // 2. IN DANH SÁCH
            Console.WriteLine("\n=== DANH SÁCH NHÂN VIÊN VỪA NHẬP ===");
            foreach (NhanVien nv in dsNhanVien)
            {
                nv.Xuat(); // Máy tính tự động phân biệt ai là Văn Phòng, ai là Sản Xuất để in cho đúng
            }
            // 3. THUẬT TOÁN SẮP XẾP GIẢM DẦN BẰNG LINQ
            Console.WriteLine("\n=== DANH SÁCH NHÂN VIÊN LƯƠNG GIẢM DẦN ===");

            // OrderByDescending: Đây là thuật toán sắp xếp (thường là QuickSort hoặc TimSort được Microsoft viết sẵn).
            // Ý nghĩa biểu thức (x => x.Luong): "Hãy lấy thuộc tính Lương của từng nhân viên (x) ra làm tiêu chí so sánh, ai lương to hơn thì đẩy lên đầu".
            var dsSapXep = dsNhanVien.OrderByDescending(x => x.Luong).ToList();
            foreach (NhanVien nv in dsSapXep)
            {
                nv.Xuat();
            }

            Console.ReadLine();
        }
    }
}