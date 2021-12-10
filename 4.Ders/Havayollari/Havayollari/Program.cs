using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havayollari
{
    class Program
    {
        static int koltuksecim;
       static string[] economy = { "", "", "", "", "", "", "", "", "", "", "", "" };
     static   string[] business = { "", "", "", "", "", "", "", "" };
       static string isim, tus;
        static void Main(string[] args)
        {
            anaMenu();
            isimal();
            koltukkontrol();
            rezervasyon();
            Main(null);
        }
        private static void anaMenu()
        {
            Console.WriteLine("1. Business Class bölümü için 1 tuşuna basın");
            Console.WriteLine("2. Economy Class bölümü için 2 tuşuna basın");
            tus = Console.ReadLine();
            switch (tus)
            {case "1":
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir karakter giriniz");
                    anaMenu();
                    break; }
        }
        private static void isimal()
        {
            Console.Write("Lütfen Adınızı giriniz=");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
            { if (char.IsDigit(isim[i]) == true)
                { Console.WriteLine("Lütfen sayısal bir karakter girmeyiniz..");
                    isimal();
                }
            }
        }
        private static void koltukkontrol()
        {
            int sayac = 0;
            if (tus == "1")
            {
                for (int i = 0; i < business.Length; i++)
                {
                    if (business[i] == "")
                    {
                        Console.WriteLine($"{i}. koltuk boş");
                    }
                    else
                    {
                        sayac++;
                        Console.WriteLine($"{i}. koltuk dolu");
                    }

                }
                if (sayac == business.Length)
                {
                    Console.WriteLine("Bu salonumuz dolmuştur.");
                }
                else if (sayac != business.Length)
                {
                    Console.WriteLine("Bu salonda yerimiz mevcuttur.");

                }

            }

            else if (tus == "2")
            {
                for (int i = 0; i < economy.Length; i++)
                {
                    if (economy[i] == "")
                    {

                        Console.WriteLine("{0}.Koltuk Boş", i);
                    }
                    else
                    {
                        sayac++;
                        Console.WriteLine("{0}.Koltuk Dolu", i);
                    }

                }
                if (sayac == economy.Length)
                {
                    Console.WriteLine("Bu salonumuz dolmuştur.");
                }
                else if (sayac != economy.Length)
                {
                    Console.WriteLine("Bu salonda yerimiz mevcuttur.");

                }
            }



            }

        private static void rezervasyon()
        {
            if (tus == "1")
            {
                Console.Write("İstediğiniz koltğu seçiniz");
                koltuksecim = Convert.ToInt32(Console.ReadLine());
                if (business[koltuksecim] == "")
                {

                    business[koltuksecim] = isim;

                }
                else
                {
                    Console.WriteLine("{0} Numaralı koltuğu daha önce {1} isimli yolcuya rezerve ettiniz! Lütfen boş koltuklardan birisini seçiniz. ", koltuksecim, business[koltuksecim]);
                    rezervasyon();
                }
                Console.WriteLine("{0}.koltuk {1} rezerve edilmiştir", koltuksecim, business[koltuksecim]);
                koltukkontrol();
            }
            else if (tus == "2")
            {
                Console.Write("İstediğiniz koltuğu seçiniz");
                koltuksecim = Convert.ToInt32(Console.ReadLine());
                if (economy[koltuksecim] == "")
                {

                    economy[koltuksecim] = isim;

                }
                else
                {
                    Console.WriteLine("{0} Numaralı koltuğu daha önce {1} isimli yolcuya rezerve ettiniz! Lütfen boş koltuklardan birisini seçiniz. ", koltuksecim, economy[koltuksecim]);
                    rezervasyon();
                }
                Console.WriteLine("{0}.koltuk {1} rezerve edilmiştir", koltuksecim, economy[koltuksecim]);
                koltukkontrol();
            }
        }
    }
}
