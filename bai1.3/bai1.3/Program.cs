using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chieuDai;
            double chieuRong;
            double chuVi;
            double dienTich;

            Console.WriteLine("CHUONG TRINH TINH CHU VI VA DIEN TICH HINH CHU NHAT");

            Console.Write("Nhap chieu dai = ");
            chieuDai = double.Parse(Console.ReadLine());

            Console.Write("Nhap chieu rong = ");
            chieuRong = double.Parse(Console.ReadLine());

            chuVi = (chieuDai + chieuRong) * 2;
            dienTich = chieuDai * chieuRong;

            Console.WriteLine("Chu vi hinh chu nhat = " + chuVi);
            Console.WriteLine("Dien tich hinh chu nhat = " + dienTich);

            Console.ReadLine();
        }
    }
}
