using System;
namespace QuanLyXeOOP
{
    class XeCon : Xe
    {
        public int SoChoNgoi { get; set; }
        public string LoaiXe { get; set; }
        public XeCon() : base()
        {
        }
        public XeCon(string bienSo, int namSX, double gia, int soCho, string loai)
            : base(bienSo, namSX, gia)
        {
            SoChoNgoi = soCho;
            LoaiXe = loai;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số chỗ ngồi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập loại xe (Sedan/SUV/Bán tải): ");
            LoaiXe = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" | Số chỗ: {SoChoNgoi} | Loại: {LoaiXe}");
        }
    }
}