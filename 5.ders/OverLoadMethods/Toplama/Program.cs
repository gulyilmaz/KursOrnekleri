using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Toplama
{
    class Program
    {
         public static int[] Sayilar = { 10, 20, 25, 28, 34 };
        public static double Sonuc;
        public static string SonucStr;
        static void Main(string[] args)
        {
            ToplamAl(true, 1 ,3,5,5,8,9,9,888);
            Console.WriteLine(Sonuc);
            Console.ReadKey();
        }
        public static double ToplamAl(Double Sayi1, Double Sayi2)
        {

            return Sonuc = Sayi1 + Sayi2;

        }
        public static string ToplamAl(string Ad, string Soyad)
        {
            return SonucStr = Ad + " " + Soyad;
        }
        public static Double ToplamAl(int[] Dizi)
        {
            for (int i = 0; i < Dizi.Length; i++)
            {
                 Sonuc += Dizi[i];
            }
            return Sonuc;
        }
        // Param en sağda olur 
        public  static Double ToplamAl(bool b ,params int[] Dizi)
        {
            foreach (var item in Dizi)
            {
                Sonuc += item;
            }
            return Sonuc;
        }
        //public static Double ToplamAl(params int[] Dizi)
        //{
        //    foreach (var item in Dizi)
        //    {
        //        Sonuc += item;
        //    }
        //    return Sonuc;
        //}
    }
}

