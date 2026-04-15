using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ôn_thi
{
    internal class Program
    {
        class XeMay
        {
            private string _bienSo;
            private int _namSX;
            private double _giaBan;

            public string BienSo
            {
                get { return _bienSo; }
                set { _bienSo = value; }
            }
            public int NamSX
            {
                get { return _namSX; }
                set
                {
                    if (value > 0)
                        _namSX = value;
                }
            }
            public double GiaBan
            {
                get { return _giaBan; }
                set
                {
                    if (value > 0)
                        _giaBan = value;
                }
            }
            public XeMay()
            {
                _bienSo = "";
                _namSX = 2026;
                _giaBan = 100000000;
            }
            public XeMay(string bienSo, int namSX, double giaBan)
            {
                this.BienSo = bienSo;
                this.NamSX = namSX;
                this.GiaBan = giaBan;
            }
            public virtual void Nhap()
            {
                Console.Write("Nhap bien so: ");
                BienSo = Console.ReadLine();
                Console.Write("Nhap nam san xuat: ");
                NamSX = int.Parse(Console.ReadLine());
                Console.Write("Nhap gia ban: ");
                GiaBan = double.Parse(Console.ReadLine());
            }
            public virtual void Xuat()
            {
                Console.Write($"BS: {BienSo} | Nam SX: {NamSX} | Gia: {GiaBan:N0} VND | ");
            }
            public virtual int ThoiHanSuDung()
            {
                return 0;
            }
        }
        class XeDien : XeMay
        {
            private double _congSuat;
            private const int THOIHAN = 10;
            public double CongSuat
            {
                get { return _congSuat; }
                set
                {
                    if (value > 0)
                        _congSuat = value;
                }
            }
            public XeDien() : base() { _congSuat = 0; }
            public XeDien(string bienSo, int namSX, double giaBan, double congSuat) : base(bienSo, namSX, giaBan)
            {
                CongSuat = congSuat;
            }
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhap cong suat (Watt): ");
                CongSuat = double.Parse(Console.ReadLine());
            }
            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine($"Cong suat: {CongSuat} (W)");
            }
            public override int ThoiHanSuDung()
            {
                int namHienTai = DateTime.Now.Year;
                return THOIHAN - (namHienTai - NamSX);
            }
        }
        static void Main(string[] args)
        {
            {
                {
                    Console.Write("Nhap so luong xe dien: ");
                    int n = int.Parse(Console.ReadLine());
                    List<XeDien> dsXe = new List<XeDien>();
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Nhap thong tin xe thu {i + 1}: ");
                        XeDien xe = new XeDien();
                        xe.Nhap();
                        dsXe.Add(xe);
                    }

                    Console.WriteLine("Danh sach xe dien vua nhap: ");
                    foreach (var xe in dsXe)
                        xe.Xuat();

                    for (int i = 0; i < dsXe.Count - 1; i++)
                    {
                        for (int j = i + 1; j < dsXe.Count; j++)
                        {
                            if (dsXe[i].ThoiHanSuDung() < dsXe[j].ThoiHanSuDung())
                            {
                                XeDien temp = dsXe[i];
                                dsXe[i] = dsXe[j];
                                dsXe[j] = temp;
                            }
                        }
                    }

                    Console.WriteLine("Danh sach xe sau khi sap xep giam dan: ");
                    foreach (var xe in dsXe)
                        xe.Xuat();

                    Console.WriteLine("Cac xe het thoi han su dung: ");
                    bool checkExpired = false;
                    foreach (var xe in dsXe)
                    {
                        if (xe.ThoiHanSuDung() <= 0)
                        {
                            xe.Xuat();
                            checkExpired = true;
                        }
                    }
                    if (!checkExpired)
                        Console.WriteLine("Khong co xe nao het han");
                }
            }
        }
    }
}

    

    
