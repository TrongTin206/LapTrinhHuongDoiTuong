using System;

namespace QuanLyXeOOP
{
    class Xe
    {
        public string BienSo { get; set; }
        public int NamSanXuat { get; set; }
        public double Gia { get; set; }
        public Xe()
        {
        }
        public Xe(string bienSo, int namSanXuat, double gia)
        {
            BienSo = bienSo;
            NamSanXuat = namSanXuat;
            Gia = gia;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhập biển số: ");
            BienSo = Console.ReadLine();
            Console.Write("Nhập năm sản xuất: ");
            NamSanXuat = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá (triệu đồng): ");
            Gia = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write($"Biển số: {BienSo,-10} | Năm SX: {NamSanXuat} | Giá: {Gia} triệu");
        }
    }
}