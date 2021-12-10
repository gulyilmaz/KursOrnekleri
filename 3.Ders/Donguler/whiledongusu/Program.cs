using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiledongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            #region While Döngüsü Genel Kullanımı 
            //while (true) // Şartımız true olduğu süre boyunca döngümüz çalışmasına devam eder. 
            //{
            //    /*
            //     * 1 - While ( False ) 
            //     * 2 - Break; 
            //     */
            //}



            #endregion

            #region Örnek Kullanım 1 : Ekrana 1 - 10 a kadar sayıların değerlerini yazdıralım. 

            // For döngüsü ile bu işlemin cevabı 

            //for(int i=1;i<=10;i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int sayac = 0;
            //while(sayac<10)
            //{
            //    sayac++;
            //    Console.WriteLine(sayac);


            //}


            //Console.ReadLine();





            #endregion

            #region Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadar ekrana yazalım 
            /*
             * 3
             * 2
             * 1
             * 0
             */
            //int sayac = 3;
            //while(sayac!=-1)
            //{
            //    Console.WriteLine(sayac);
            //    sayac--;
            //}
            //Console.ReadLine();


            #endregion


            #region Kullanıcıya şifre soran bilinemez ise 5 hak tanıyan her seferinde kalan hakkıda belirten program sifre: 1234
            //int sayac = 5;
            //int sifre = 1234;
            //while(sayac>0)
            //{
            //    Console.WriteLine("şifreyi giriniz");
            //    int s = Convert.ToInt32(Console.ReadLine());
            //    sayac--;
            //    if(s==sifre)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else if(sifre!=s)
            //    {
            //        Console.WriteLine($"kalan hakkınız :{sayac} ");
            //    }
            //    if(sayac==0)
            //    {
            //        Console.WriteLine("yanlış şifre girdiniz");
            //    }


            //}




            //Console.ReadLine();

            #endregion
            #region Ödev : Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım. 
            Random sayiuret = new Random();
            int uretilensayi = sayiuret.Next(1, 10);
            int tahmin = 1;
            while(true)
            {
                Console.WriteLine("Tuttuğum sayıyı tahmin et");
                int s = Convert.ToInt32(Console.ReadLine());
                tahmin++;
                if(uretilensayi==s)
                { Console.WriteLine($"{tahmin} . tahminde doğru bildiniz");
                    break;
                }
                else { Console.WriteLine("yanlış tahmin yeniden deneyiniz"); }



            }
            Console.ReadLine();



            #endregion


        }
    }
}
