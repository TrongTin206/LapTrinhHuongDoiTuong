using System;
namespace QuanLyNhanVienOOP
{
    class NhanVien
    {
        // Các thuộc tính chung
        public string HoTen { get; set; }
        public string NgaySinh { get; set; } // Dùng string cho đơn giản, nếu nâng cao có thể dùng DateTime
        public double Luong { get; set; }    // Lương để trống, lát nữa lớp con tự tính rồi gán vào đây
        public NhanVien() { }
        public NhanVien(string hoTen, string ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }
        // virtual: Cho phép lớp con được viết đè lên để nhập thêm thông tin riêng
        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập ngày sinh (vd: 01/01/2000): ");
            NgaySinh = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            // In ra định dạng cột cho đẹp. -20 nghĩa là canh trái 20 ký tự
            Console.Write($"Họ tên: {HoTen,-20} | Ngày sinh: {NgaySinh,-12} | Lương: {Luong,10:N0} VNĐ");
        }
    }
}