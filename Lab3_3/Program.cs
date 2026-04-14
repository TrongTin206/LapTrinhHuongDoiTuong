using System;

namespace QuanLyHinhVeOOP
{
    // ==========================================
    // 1. LỚP CƠ SỞ: HÌNH VẼ
    // ==========================================
    class HinhVe
    {
        // Phương thức ảo để nhập dữ liệu. 
        // Lớp con sẽ tự quyết định xem nó cần nhập gì (bán kính hay chiều dài...)
        public virtual void Nhap()
        {
            // Ở lớp cơ sở chung chung thế này, ta không có gì để nhập cả.
        }

        // Phương thức ảo tính diện tích trả về double.
        // Mặc định trả về 0 vì "Hình vẽ" nói chung thì không có công thức.
        public virtual double DienTich()
        {
            return 0;
        }
    }

    // ==========================================
    // 2. LỚP CON 1: HÌNH TRÒN (Kế thừa Hình Vẽ)
    // ==========================================
    class HinhTron : HinhVe
    {
        public double BanKinh { get; set; }

        public override void Nhap()
        {
            Console.Write("Nhập bán kính hình tròn: ");
            BanKinh = double.Parse(Console.ReadLine());
        }

        public override double DienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
    }
    class HinhChuNhat : HinhVe
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public override void Nhap()
        {
            Console.Write("Nhập chiều dài: ");
            ChieuDai = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            ChieuRong = double.Parse(Console.ReadLine());
        }

        public override double DienTich()
        {
            return ChieuDai * ChieuRong;
        }
    }
    class HinhVuong : HinhChuNhat
    {

        public override void Nhap()
        {
            Console.Write("Nhập cạnh hình vuông: ");
            double canh = double.Parse(Console.ReadLine());
            ChieuDai = canh;
            ChieuRong = canh;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== CHỌN LOẠI HÌNH VẼ ĐỂ TÍNH DIỆN TÍCH ===");
            Console.WriteLine("1. Hình Tròn");
            Console.WriteLine("2. Hình Chữ Nhật");
            Console.WriteLine("3. Hình Vuông");
            Console.Write("Lựa chọn của bạn (1/2/3): ");
            int chon = int.Parse(Console.ReadLine());
            HinhVe hinh = null;
            switch (chon)
            {
                case 1:
                    hinh = new HinhTron();
                    break;
                case 2:
                    hinh = new HinhChuNhat();
                    break;
                case 3:
                    hinh = new HinhVuong();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return; // Kết thúc chương trình luôn
            }
            Console.WriteLine("\n--- TIẾN HÀNH NHẬP DỮ LIỆU ---");
            hinh.Nhap();
            double dienTich = hinh.DienTich();
            Console.WriteLine($"\n=> DIỆN TÍCH CỦA HÌNH LÀ: {dienTich:F2}");
            Console.ReadLine();
        }
    }
}