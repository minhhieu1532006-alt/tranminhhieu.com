using System;
namespace NamAmLich
{
    class Program
    {
        static void Main(string[] args)
        {
            int nam;
            string[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui" };
            Console.Write("Nhap nam duong lich: ");
            nam = int.Parse(Console.ReadLine());
            if (nam > 0)
            {
                Console.WriteLine("Nam am lich tuong ung: " + can[nam % 10] + " " + chi[nam % 12]);
            }
            else
                Console.WriteLine("Nam phai la so duong");
            Console.ReadLine();
        }
    }
}