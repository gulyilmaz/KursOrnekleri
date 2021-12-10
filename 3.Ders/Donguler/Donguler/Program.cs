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

            //for (int i = 1; i <=5; i++)
            //{
            //    //çalışacak kodlarım
            //    Console.WriteLine("merhaba");
            //}
           

        


            #endregion
            Console.Clear();
            #region Ekran üzerinde 1 - 10 arasındaki değerleri yazdıralım. 
            //for (int i = 1; i <10; i++ )
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            Console.Clear();
            #region 1 - 100 arasındaki çift sayıları ekran üzerinde yazdıralım. 

            //for (int i = 1; i <=100; i++)
            //{if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.ReadLine();






            #endregion
            Console.Clear();
            #region Küçük ödev : 1 - 100 arasındaki çift sayıların toplamı nedir ? 

            //int toplam = 0;
            //for(int i=1;i<=100;i++)
            //{
            //    if(i%2==0)
            //    {
            //      //  toplam = toplam + i;
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine($"Çift sayıların toplamı {toplam}");

            //Console.ReadLine();


            #endregion

            Console.Clear();
            #region Alfabeyi yazdıralım
            //for(char i='A';i<='Z';i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            #endregion
            #region Küçük ödev: Alfabeyi tersten yazdıralım

            //for (char i='Z';i>='A';i--)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();

            #endregion
            #region Küçük ödev2: 100 den geriye doğru rakamları 4 er 4 er  tersten yazdıralım

            //for (int i=100;i>=0;i-=4 )
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            #endregion
            #region Kullanıcı ekran üzerinden bir sayı girişi yapacak . (5) Girilenn sayısının faktöriyel hesabını alıp ekrana yazdıralım. 

            //int faktoriyel = 1;
            //Console.WriteLine("faktöriyelini almak istediğiniz sayıyı giriniz");
            //int s = Convert.ToInt32(Console.ReadLine());

            //for(int i=s;i>1;i--)
            //{
            //    faktoriyel = faktoriyel * i;

            //}
            //Console.WriteLine($"Girdiğiniz {s} sayısının faktöriyeli {faktoriyel}");
            //Console.ReadLine();
            #endregion

            #region Girilen sayının ortalamasını bulalım.Kaç adet sayının ortalamasının bulunacağına kullanıcı karar versin.


            //Console.WriteLine("kaç sayının ortalamasını alacaksınız");
            //double s = Convert.ToDouble(Console.ReadLine());
            //double toplam = 0, ort = 0;
            //for(int i=1;i<=s;i++)
            //{
            //    Console.WriteLine($"{i}.sayıyı giriniz");
            //    double s1 = Convert.ToDouble(Console.ReadLine());
            //    toplam = toplam + s1;


            //}

            //ort = toplam / s;
            //Console.WriteLine(ort);

            //Console.ReadLine();

            #endregion
            Console.Clear();
            
            
            #region iç içe for döngüsü kullanımı 

            //for(int i=1;i<=4;i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int f=5;f>0;f--)
            //{
            //    for (int h = 1; h <=f; h++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}





            //Console.ReadLine();

            #endregion
            #region Eni boyu kullanıcıdan alınan bir (yıldızlarla) dörtgen çizelim.Kullanıcı aynı değeri sunarsa kare çizdirmek istedeniz uyarısı verelim ve programı sonlandıralım.
            // *********
            // *********
            // *********
            // *********

            //Console.WriteLine("En değerini giriniz");
            //int en = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Boy değerini giriniz");
            //int boy = Convert.ToInt32(Console.ReadLine());
            //if(en==boy)
            //{ Console.WriteLine("kare çizdirmek istediniz"); }

            //else
            //{
            //    for (int i = 1; i <=boy; i++)
            //    {
            //        for(int j=1;j<=en;j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
                
            //}
            //Console.ReadLine();
            #endregion
            Console.Clear();
            #region Ödev : Çarpım Tablosu 
            /*
             * 1X1 = 1   
             * 1X2 = 2   
             * 1X3 = 3   
             * 1X4 = 4   
             * 1*5 = 5   
             * 1*6 = 6   
             * .         
             * .         
             * 1*10 = 10
             * 
             * 2*1 = 2
             */
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j}");
                }
                Console.WriteLine();

            }

            Console.ReadLine();
            #endregion

            Console.Clear();





          


        }
    }
}