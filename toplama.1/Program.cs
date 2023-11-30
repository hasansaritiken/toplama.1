using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplama._1
{
    internal class Program
    {
        class DortIslem { 
            public double Topla(double x, double y)
            {
                return (x + y);
            }

            public double Cikar(double x, double y)
            {
                return (x - y);
            }

            public double Carpma(double x, double y)
            {
                return (x *y);
            }

            public double Bolme(double x, double y)
            {
                return (x / y);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz  : ");
            double  sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz  : ");
            double sayi2 = Convert.ToInt32(Console.ReadLine());
            
            DortIslem  dortislem = new DortIslem();
            Console.WriteLine("İki Sayının Toplamı = "+dortislem.Topla(sayi1,sayi2));

            DortIslem dortislemcıkarma = new DortIslem();
            Console.WriteLine("İki Sayının Farkı = " + dortislem.Cikar(sayi1, sayi2));

            DortIslem dortislemcarpma = new DortIslem();
            Console.WriteLine("İki Sayının Çarpımı = "  + dortislem.Carpma(sayi1, sayi2));

            DortIslem dortislembolme = new DortIslem();
            Console.WriteLine("İki Sayının  bölümü  = " + dortislem.Bolme(sayi1, sayi2));
            Console.ReadKey(); 
        }
    }
}
