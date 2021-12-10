using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü genel kullanımı 

            #endregion
            Console.Clear();
            #region Ekran üzerinde 1 - 10 arasındaki değerleri yazdıralım. 

            #endregion
            Console.Clear();
            #region 1 - 100 arasındaki çift sayıları ekran üzerinde yazdıralım. 

            #endregion
            Console.Clear();
            #region Küçük ödev : 1 - 100 arasındaki çift sayıların toplamı nedir ? 

            #endregion

            Console.Clear();
            #region Alfabeyi yazdıralım

            #endregion
            #region Küçük ödev: Alfabeyi tersten yazdıralım

            #endregion
            #region Küçük ödev2: 100 den geriye doğru rakamları 4 er 4 er  tersten yazdıralım

            #endregion
            #region Kullanıcı ekran üzerinden bir sayı girişi yapacak . (5) Girilenn sayısının faktöriyel hesabını alıp ekrana yazdıralım. 

            #endregion

            #region Girilen sayının ortalamasını bulalım.Kaç adet sayının ortalamasının bulunacağına kullanıcı karar versin.

            #endregion
            Console.Clear();


            #region iç içe for döngüsü kullanımı 
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 5; i >0; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.ReadLine();

            #endregion
            #region Eni boyu kullanıcıdan alınan bir (yıldızlarla) dörtgen çizelim.Kullanıcı aynı değeri sunarsa kare çizdirmek istedeniz uyarısı verelim ve programı sonlandıralım.
            // **********
            // **********
            // **********
            // **********


            #endregion
            Console.Clear();
            #region Ödev : Çarpım Tablosu 
            /*
             * 1*1 = 1   
             * 1*2 = 2   
             * 1*3 = 3   
             * 1*4 = 4   
             * 1*5 = 5   
             * 1*6 = 6   
             * .         
             * .         
             * 1*10 = 10
             * 
             * 2*1 = 2
             */



            #endregion

            Console.Clear();





            #region Sonsuz döngü oluşturmak
            //int sonsuzDonguSayac = 0;
            //for (; ; )
            //{
            //    sonsuzDonguSayac++;
            //    //break anahtar kelimesi;
            //    //if (sonsuzDonguSayac == 2)
            //    //    break;
            //    // continue anahtar kelimesi
            //    if (sonsuzDonguSayac == 2)
            //        continue;

            //    Console.WriteLine(sonsuzDonguSayac);

            //    Console.WriteLine("Merhaba ben bir sonsuz döngüyüm");
            //}
            #endregion


        }
    }
}