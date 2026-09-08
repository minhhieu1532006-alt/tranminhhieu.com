using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.WriteLine("GIAI PHUONG TRINH BAC HAI");
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem x = " + Math.Round(x, 2));
                }
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep x = " + Math.Round(x1, 2));
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet");
                    Console.WriteLine("x1 = " + Math.Round(x1, 2));
                    Console.WriteLine("x2 = " + Math.Round(x2, 2));
                }
            }
            Console.ReadLine();
        }
     }
 }
