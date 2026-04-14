using System;
namespace QuanLyNhanVienOOP
{
    class NhanVienVanPhong : NhanVien
    {
        // Thuộc tính riêng của NV Văn Phòng
        public int SoNgayLamViec { get; set; }

        public NhanVienVanPhong() : base() { }
        public override void Nhap()
        {
            Console.WriteLine("--- Nhập thông tin Nhân viên Văn phòng ---");
            base.Nhap(); // Gọi lớp cha nhập Họ tên, Ngày sinh trước

            Console.Write("Nhập số ngày làm việc: ");
            SoNgayLamViec = int.Parse(Console.ReadLine());

            // THUẬT TOÁN TÍNH LƯƠNG: Tính xong gán ngược lại vào thuộc tính Luong của lớp cha
            Luong = SoNgayLamViec * 100000;
        }
        public override void Xuat()
        {
            base.Xuat(); // In Họ tên, Ngày sinh, Lương
            Console.WriteLine($" | Loại: Văn Phòng | Số ngày làm: {SoNgayLamViec}");
        }
    }
}