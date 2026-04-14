using System;
namespace QuanLyMayIn
{
    class Printer
    {
        public string NhaSanXuat { get; set; }
        public double GiaBan { get; set; }
        public Printer()
        {
        }
        public Printer(string nhaSanXuat, double giaBan)
        {
            NhaSanXuat = nhaSanXuat;
            GiaBan = giaBan;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập nhà sản xuất: ");
            NhaSanXuat = Console.ReadLine();
            Console.Write("Nhập giá bán: ");
            GiaBan = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write($"Hãng SX: {NhaSanXuat,-10} | Giá bán: {GiaBan,10:N0} VNĐ ");
        }
    }
    class LaserPrinter : Printer
    {
        public string DoPhanGiai { get; set; }

        public LaserPrinter() : base()
        {
        }
        public LaserPrinter(string nhaSanXuat, double giaBan, string doPhanGiai)
            : base(nhaSanXuat, giaBan)
        {
            DoPhanGiai = doPhanGiai;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập độ phân giải: ");
            DoPhanGiai = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat(); 
            Console.WriteLine($"| Độ phân giải: {DoPhanGiai}");
        }
    }
}