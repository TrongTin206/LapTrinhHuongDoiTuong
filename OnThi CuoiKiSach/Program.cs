using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi_CuoiKiSach
{
    abstract class Book
    {
        private string Tensach;
        private int Namsanxuat;
        private int Sotrang;

        public string tensach
        {
            get { return Tensach; }
            set
            {
                if (value.Length != 0)
                    Tensach = value;
            }
        }
        public int namsanxuat
        {
            get { return Namsanxuat; }
            set
            {
                if (value > 0)
                    Namsanxuat = value;
            }
        }
        public int sotrang
        {
            get { return Sotrang; }
            set
            {
                if (value > 0)
                    Sotrang = value;
            }
        }
        public Book()
        {
            Tensach = " hehe";
            Namsanxuat = 2000;
            Sotrang = 100;
        }
        public Book(string Tensach, int Namsanxuat, int Sotrang)
        {
            Tensach = tensach;
            Namsanxuat = namsanxuat;
            Sotrang = sotrang;
        }
        public virtual void Nhap()
        {
            Console.WriteLine(" Nhap ten sach: ");
            tensach = Console.ReadLine();
            namsanxuat = int.Parse(Console.ReadLine());
            Console.Write("Nhap so trang: ");
            sotrang = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("\nTen sach: { 0}, Nam xuat ban: { 1}, So trang: { 2}", tensach, namsanxuat, sotrang);
        }
        public abstract int Giaban();
    }
    class PaperBook : Book
    {
        private string Tennhain;
        public string tennhain
        {
            get { return Tennhain; }
            set
            {
                if (value.Length != 0)
                    Tennhain = value;
            }
        }
        public PaperBook()
        {
            Tennhain = " hello";
        }
        public PaperBook(string Tensach, int Namsanxuat, int Sotrang, string TenNhaIn) : base(Tensach, Namsanxuat, Sotrang)
        {
            Tennhain = tennhain;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Ten nha in: ");
            Tennhain = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("Ten nha in: {0}", Tennhain);
        }
        public override int Giaban()
        {
            return sotrang * 400;
        }
    }
    class EBook : Book
    {
        private string _dinhDangSach;
        public string DinhDangSach
        {
            get { return _dinhDangSach; }
            set
            {
                if (value.Length != 0)
                    _dinhDangSach = value;
            }
        }
        public EBook()
        {
            DinhDangSach = "Hehe";
        }
        public EBook(string Tensach, int Namsanxuat, int Sotrang, string dinhDangSach) : base(Tensach, Namsanxuat, Sotrang)
        {
            DinhDangSach = dinhDangSach;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap dinh dang sach: ");
            DinhDangSach = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("Dinh dang sach: {0}", DinhDangSach);
        }
        public override int Giaban()
        {
            return sotrang * 100;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; do
            {
                Console.Write("Nhap so luong sach (2 <= n <= 100): ");
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 2 && n <= 100));

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap loai sach (0. PaperBook / 1. EBook): ");
                int choose = int.Parse(Console.ReadLine());

                Book book;

                if (choose == 0)
                    book = new PaperBook();
                else if (choose == 1)
                    book = new EBook();
                else
                {
                    Console.WriteLine("Khong co loai sach nay, vui long nhap lai!");
                    i--;
                    continue;
                }

                book.Nhap();
                books.Add(book);
            }

            // Cau 2: Xuat danh sach
            Console.WriteLine("\nDanh sach sach:");
            foreach (var sach in books)
            {
                sach.Xuat();
            }

            // Cau 3: Tim sach co gia ban cao nhat cua tung loai
            List<PaperBook> dsPaperBook = new List<PaperBook>();
            List<EBook> dsEBook = new List<EBook>();

            foreach (var sach in books)
            {
                if (sach is PaperBook)
                    dsPaperBook.Add((PaperBook)sach);
                else if (sach is EBook)
                    dsEBook.Add((EBook)sach);
            }

            Console.WriteLine("\nSach co gia tien cao nhat cua tung loai:");

            if (dsPaperBook.Count > 0)
            {
                PaperBook paper_max = dsPaperBook[0];

                foreach (var sach in dsPaperBook)
                {
                    if (sach.Giaban() > paper_max.Giaban())
                    {
                        paper_max = sach;
                    }
                }

                Console.WriteLine("\nPaperBook:");
                paper_max.Xuat();
            }
            else
            {
                Console.WriteLine("\nKhong co loai sach PaperBook");
            }

            if (dsEBook.Count > 0)
            {
                EBook ebook_max = dsEBook[0];

                foreach (var sach in dsEBook)
                {
                    if (sach.Giaban() > ebook_max.Giaban())
                    {
                        ebook_max = sach;
                    }
                }

                Console.WriteLine("\nEBook:");
                ebook_max.Xuat();
            }
            else
            {
                Console.WriteLine("\nKhong co loai sach EBook");
            }

            // Cau 4: Xoa cac sach thoi gian luu hanh lon hon 10 nam
            books.RemoveAll(book => DateTime.Now.Year - book.namsanxuat > 10);

            Console.WriteLine("\nDanh sach cac sach co thoi gian luu hanh it hon 10 nam:");

            foreach (var sach in books)
            {
                sach.Xuat();
            }
        }
    }
}

