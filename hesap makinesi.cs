using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Alan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin alanı için 1e \nKarenin alanı için 2ye \nDikdörtgenin alanı için 3e\nDairenin alanı için 4e\nYamuğun alanı için 5e Basınız..");
            Console.Write("yapmak istediğiniz işlemi seçin:");
            double secim = Convert.ToDouble(Console.ReadLine());
            if (secim == 1)
            {
                Console.Write("Yüksekliği giriniz:");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yüksekliğe ait kenar: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = ucgen(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 2)
            {
                Console.Write("1. kenarı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("2. kenarı giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = kare(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 3)
            {
                Console.Write("uzun kenarı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("kısa kenarı giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double sonuc = dikdortgen(sayi1, sayi2);
                Console.WriteLine(sonuc);
            }
            else if (secim == 4)
            {
                Console.Write("yarı çapı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                double pi=3.1415;
                double sonuc = daire(sayi1,pi);
                Console.WriteLine(sonuc);
            }
            else if (secim == 5)
            {
                Console.Write("alt kenarı giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("üst kenarı giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("yüksekliği giriniz: ");
                double sayi3 = Convert.ToDouble(Console.ReadLine());
                double sonuc = yamuk(sayi1, sayi2,sayi3);
                Console.WriteLine(sonuc);
            }
            else
                Console.WriteLine("YANLIŞ SEÇİM!!!");
            Console.ReadLine();
        }
        public static double ucgen(double say1, double say2)
        {
            double sonuc = say1 * say2;
            return sonuc;
        }
        public static double kare(double say1, double say2)
        {
            double sonuc = say1 * say2;
            return sonuc;
        }
        public static double dikdortgen(double say1, double say2)
        {
            double sonuc = say1 * say2;
            return sonuc;
        }
        public static double daire(double say1, double say2)
        {
            double sonuc = say1 * say2;
            return sonuc;
        }
        public static double yamuk(double a, double b,double h)
        {
            double sonuc = ((a+b)/2)*h;
            return sonuc;
        }
    }
}
