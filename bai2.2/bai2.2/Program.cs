using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, chuVi, dienTich, p;
            Console.WriteLine("TINH CHU VI VA DIEN TICH TAM GIAC");
            Console.Write("Nhap canh a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                chuVi = a + b + c;
                p = chuVi / 2;
                dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Chu vi tam giac = " + chuVi);
                Console.WriteLine("Dien tich tam giac = " + Math.Round(dienTich, 2));
            }
            else
                Console.WriteLine("Khong lap thanh tam giac");
            Console.ReadLine();
        }
    }
}
