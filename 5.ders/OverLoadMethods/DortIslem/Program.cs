using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem
{
    class Program
    {
        public static double Sonuc;

        static void Main(string[] args)
        {
           Topla(3, 2);
            Console.WriteLine(Sonuc);
            Console.ReadKey();
        }
        public static double Topla(Double Sayi1, Double Sayi2)
        {
                return Sonuc = Sayi1 + Sayi2;
        }
            //public static double Islem(Double Sayi1, Double Sayi2, String Islem = "-")
            //{
            //    if (Islem == "-")
            //    {
            //        return Sonuc = Sayi1 - Sayi1;
            //    }
            //    else return 0;
            //}
        }
    }


 
