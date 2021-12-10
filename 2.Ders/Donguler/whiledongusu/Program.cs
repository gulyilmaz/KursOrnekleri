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
            int i = 1;
            while(i<10)
                {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();




            #endregion
            Console.Clear();
            #region Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadar ekrana yazalım 
            /*
             * 3
             * 2
             * 1
             * 0
             */
           
            #endregion
            Console.Clear();



            #region Kullanıcıya şifre soran bilinemez ise 5 hak tanıyan her seferinde kalan hakkıda belirten program sifre: 1234

            #endregion
            #region Ödev : Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım. 

            int sistemUretSayi = 0;
            int tahmminAdet = 1;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1, 10);

            while (true)
            {

                Console.Write("{0} . deneme - Lütfen sistemin üretmiş olduğu sayıyı tahmin ediniz :", tahmminAdet);
                string rndKullaniciGelen = Console.ReadLine();

                int rndKullaniciGelenInt = int.Parse(rndKullaniciGelen);

                //if (int.Parse(rndKullaniciGelen) == sistemUretSayi)
                if (rndKullaniciGelenInt == sistemUretSayi)
                {
                    tahmminAdet++;
                    Console.WriteLine("{0}. denemenizde değeri buldunuz Tebrikler !", tahmminAdet);
                    Console.ReadLine();
                    break;
                }
                else
                {
                   // Console.Clear();
                    Console.WriteLine("{0} . denemeniz , Tahmin edemediniz lütfen yeniden deneyin ...", tahmminAdet);
                    tahmminAdet++;

                }
            }
            #endregion


        }
    }
}
