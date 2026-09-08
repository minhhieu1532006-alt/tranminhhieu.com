using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Nhap so thu nhat a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai b = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Tong = " + (a + b));
            Console.WriteLine("Hieu = " + (a - b));
            Console.WriteLine("Tich = " + (a * b));

            if (b != 0)
            {
                Console.WriteLine("Thuong = " + ((double)a / b));
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0");
            }

            Console.ReadLine();
        }
    }
}
