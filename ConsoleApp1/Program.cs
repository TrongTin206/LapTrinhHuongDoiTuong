namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace Bai2_2
    {
        //Khai báo lớp Phân số (dùng lại từ bài 2.1)
        public class PhanSo
        {
            private int _tuSo;
            private int _mauSo;

            public int TuSo { get { return _tuSo; } set { _tuSo = value; } }

            public int MauSo
            {
                get { return _mauSo; }
                set
                {
                    if (value == 0)
                    {
                        Console.WriteLine("Mau so phai khac 0");
                        _mauSo = 1;
                    }
                    else
                        _mauSo = value;
                }
            }

            public PhanSo(int ts, int ms)
            {
                TuSo = ts;
                MauSo = ms;
            }

            public void Nhap()
            {
                Console.Write("Nhap tu so: ");
                TuSo = int.Parse(Console.ReadLine());

                Console.Write("Nhap mau so: ");
                MauSo = int.Parse(Console.ReadLine());
            }

            public void Xuat()
            {
                Console.Write($"{_tuSo}/{_mauSo} ");
            }

            public double GiaTri()
            {
                return (double)_tuSo / _mauSo;
            }
        }


        //Khai báo lớp DSPhanSo
        public class DSPhanSo
        {
            private PhanSo[] _dsPS;
            private int _size;

            public PhanSo[] DSPS
            {
                get { return _dsPS; }
                set { _dsPS = value; }
            }

            public int Size
            {
                get { return _size; }
                set { _size = value; }
            }

            // Nhập danh sách phân số
            public void Nhap()
            {
                Console.Write("Nhap so luong phan so: ");
                _size = int.Parse(Console.ReadLine());

                _dsPS = new PhanSo[_size];

                for (int i = 0; i < _size; i++)
                {
                    Console.WriteLine($"Nhap phan so thu {i + 1}:");
                    _dsPS[i] = new PhanSo(0, 1);
                    _dsPS[i].Nhap();
                }
            }

            // Xuất danh sách phân số
            public void Xuat()
            {
                Console.WriteLine("Danh sach phan so:");
                for (int i = 0; i < _size; i++)
                    _dsPS[i].Xuat();

                Console.WriteLine();
            }

            // Tìm phân số lớn nhất
            public PhanSo Max()
            {
                PhanSo max = _dsPS[0];

                for (int i = 1; i < _size; i++)
                    if (_dsPS[i].GiaTri() > max.GiaTri())
                        max = _dsPS[i];

                return max;
            }

            // Sắp xếp tăng dần
            public void SapXepTang()
            {
                for (int i = 0; i < _size - 1; i++)
                    for (int j = i + 1; j < _size; j++)
                        if (_dsPS[i].GiaTri() > _dsPS[j].GiaTri())
                        {
                            PhanSo temp = _dsPS[i];
                            _dsPS[i] = _dsPS[j];
                            _dsPS[j] = temp;
                        }
            }

        } // End of class DSPhanSo


        // Main program 
        class Program
        {
            static void Main()
            {
                DSPhanSo ds = new DSPhanSo();

                ds.Nhap();
                ds.Xuat();

                Console.Write("Phan so lon nhat: ");
                ds.Max().Xuat();

                ds.SapXepTang();

                Console.WriteLine("\nDanh sach sau khi sap xep tang:");
                ds.Xuat();
            }
        } // End of class Program
    }
}
    }
}
