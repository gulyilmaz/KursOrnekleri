using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            // Nasıl değer ekleyebiliriz. 
            // 1 2 3 4 ... 10 
            // 0 1 2 3 4 5 6 7 8 9 10
            /*
             * 5 elemanlı bir dizi oluşturuduğum zaman 
             * 
             * [0]
             * [1]
             */


            //1.Yol dizi tanımlarken tüm elemanları girmek

            string[] isim = { "ali", "demet", "seda" };

            //2.yol Dizi tanımlanır.Eleman sayısı bildirilir.
            int[] s = new int[5];


            //3.yol Dizi tanımlanır.Eleman sayısı ve elemanları belirlenir.
            int[] a = new int[4] { 1, 2, 3, 4 };


            //4.yol Dizi tanımlanır,elemanlar indeksleri ile sonradan bildirilir.
            int[] b = new int[4];
            b[0] = 5;
            b[1] = 3;
            b[2] = 4;
            b[3] = 8;


            #region oluşturmuş olduğumuz dizimizin içerisindeki elemanları ekrana yazdıralım. 

            //foreach(int sayi in b)
            //{
            //    Console.WriteLine(sayi);
            //}
            //Console.ReadLine();



            #endregion
            #region forla diziyi yazdırma

            //for(int i=0;i<b.Length;i++)
            //{
            //    Console.WriteLine(b[i]);
            //}
            //Console.ReadLine();

            #endregion

            #region uygulama: int veri tipinde dizi oluşturalım.Kullanıcımız dizinin kaç elemanlı olacağı bilgisini versinve içerisine elemanların atamasını yapsın.Daha sonra dizi içerisindeki elemanların toplamlarını ve ortalamalarını ekrana yazdıran uygulama.
            //Console.WriteLine("kaç elemanlı dizi oluşturmak istersiniz");
            //int elemanS = Convert.ToInt32(Console.ReadLine());
            //int[] sayi = new int[elemanS];
            //int toplam = 0, ort = 0;
            //for(int i=0;i<sayi.Length;i++)
            //{
            //    Console.WriteLine($"{i} indeksine sayı giriniz");
            //    int eleman = Convert.ToInt32(Console.ReadLine());
            //    sayi[i] = eleman;
            //}
            //foreach(int item in sayi)
            //{
            //    Console.WriteLine(item);
            //    toplam += item;
            //}
            //Console.WriteLine($"SAyıların toplamı {toplam}");
            //ort = toplam / sayi.Length;
            //Console.WriteLine($"Sayıların ortalaması {ort}");

            //Console.ReadLine();
            #endregion
            #region uygulama: 20 elemanlı bir int dizisi oluşturalım.Değerlerimizi random sınıfının next fonksiyonu ile 1 ila 10 arasında dolduralım daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri olduğunu bulalım

            int[] dizi = new int[20];
            Random rnd = new Random();
            int sayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 10);
            }
            foreach(int item in dizi)
            {
                Console.WriteLine(item);
                if(item==4)
                { sayac++; }

            }
            Console.WriteLine($"{sayac} adet 4 bulundu");


            Console.ReadLine();

            #endregion
        }
    }
}
