using Lab4_Bai41;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab4_Bai41{ 
    internal class HexaStack : Stack
    {
        public HexaStack(int _max) : base(_max)
        {
        }

        public override void Print()
        {
            string hex = "0123456789ABCDEF";
            while (!IsEmpty())
            {
                Console.Write(hex[Pop()]);
            }
            Console.WriteLine();
        }
    }
    internal class Bai2_5
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Phân tích thừa số nguyên tố
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int m = n;

            Stack stackNT = new PrimeStack(100);
            int i = 2;
            while (n != 1)
            {
                while (n % i == 0)
                {
                    stackNT.Push(i);
                    n = n / i;
                }
                i++;
            }
            Console.Write($"{m} = ");
            stackNT.Print();
            Console.WriteLine();
            // Đổi sang hệ 16
            Console.Write("Nhập số nguyên để đổi sang hệ 16: ");
            int num = int.Parse(Console.ReadLine());
            Stack stackHex = new HexaStack(100);
            int tempHex = num;
            while (tempHex > 0)
            {
                stackHex.Push(tempHex % 16);
                tempHex /= 16;
            }
            Console.Write($"{num} (Hex) = ");
            stackHex.Print();
        }
    }
}