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

            string[] isimler = { "ali", "veli" };
            //2.yol Dizi tanımlanır.Eleman sayısı bildirilir.

            string[] ad = new string[5];


            //3.yol Dizi tanımlanır.Eleman sayısı ve elemanları belirlenir.

            string[] ay = new string[2] { "ocak", "şubat" };



            //4.yol Dizi tanımlanır,elemanlar indeksleri ile sonradan bildirilir.

            int[] sayi = new int[3];

            sayi[0] = 1;
            sayi[1] = 2;
            sayi[2] = 3;


            #region oluşturmuş olduğumuz dizimizin içerisindeki elemanları ekrana yazdıralım. 






            #endregion
            #region forla diziyi yazdırma
            //for (int uygulamaSayac = 0; uygulamaSayac < uygulama1Dizi.Length; uygulamaSayac++)
            //{
            //    Console.WriteLine("{0}. index e denk gelen değeri giriniz", uygulamaSayac);

            //    uygulama1Dizi[uygulamaSayac] = int.Parse(Console.ReadLine());
            //}
            #endregion

            #region Uygulama 1 : int veri tipinde bir dizi oluşturalım , kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin, ve dizi içindeki alanlara değer ataması yapsın. Daha sonra dizi içerisindeki elemanların toplamlarını ve ortalamasını ekrana yazdıran bir uygulama yazalım. 

            //Console.WriteLine("Lütfen oluşturmak istediğiniz veri kümesinin uzunluğunu giriniz");
            //string uygulama1DiziUzunluk = Console.ReadLine();
            //int uygulamaDiziUzunlukInt = int.Parse(uygulama1DiziUzunluk);

            //int[] uygulama1Dizi = new int[uygulamaDiziUzunlukInt];

            //for (int uygulamaSayac = 0; uygulamaSayac < uygulama1Dizi.Length; uygulamaSayac++)
            //{
            //    Console.WriteLine("{0}. index e denk gelen değeri giriniz", uygulamaSayac);

            //    uygulama1Dizi[uygulamaSayac] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Tebrikler dizinin içerisindeki tüm alanları doldurdunuz");

            //Console.WriteLine("Dizi içerisindeki değerler ve toplam, ortalama değeri aşağıdaki gibidir.");

            //int uygulama1Toplam = 0, uygulama1Ortalama = 0;
            //foreach (int item in uygulama1Dizi)
            //{
            //    Console.WriteLine(item);
            //    uygulama1Toplam = uygulama1Toplam + item;
            //}
            //Console.WriteLine("+----------------------------");

            //Console.WriteLine(uygulama1Toplam);

            //Console.WriteLine("Dizi içerisindeki eleman sayısı : {0}", uygulama1Dizi.Length);
            //uygulama1Ortalama = uygulama1Toplam / uygulama1Dizi.Length;
            //Console.WriteLine("Ortalama : {0}", uygulama1Ortalama);

            #endregion

            #region Uygulama 2: 20 elemanlı bir int dizi oluşturalım. Değerlerimizi random sınıfının next fonksiyonu ile 1 - 10 arasındaki değerler ile dolduralm. Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri olduğunu bulalım. 

            Random Rnd = new Random();

            int[] uygulama2Dizi = new int[20];
            for (int uygulama2Sayac = 0; uygulama2Sayac < uygulama2Dizi.Length; uygulama2Sayac++)
            {
                uygulama2Dizi[uygulama2Sayac] = Rnd.Next(1, 10);
            }

            int uygulama2Bul = 0;

            foreach (int item in uygulama2Dizi)
            {
                Console.WriteLine(item);
                if (item == 4)
                    uygulama2Bul++;
            }

            Console.WriteLine("Dizi içindeki 4 değeri {0} adettir.", uygulama2Bul);
            #endregion


        }
    }
}
