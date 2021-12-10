using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Yapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            // ********* REPLACE *******/////////

            //string cumle = "Selam Nasılsın";
            //string yenicumle = cumle.Replace("Selam Nasılsın", "Slm nbr");
            //Console.WriteLine(yenicumle);
            //Console.ReadLine();



            //********** REMOVE **************//

            //string cumle = "Selam Nasılsın";
            //string yenicumle = cumle.Remove(0,6);
            //Console.WriteLine(yenicumle);
            //Console.ReadLine();


            //******** SUBSTRING ***************//

            //string cumle = "Selam Nasılsın";
            //string yenicumle = cumle.Substring(0,6);//Tek sayısal ifade girildiği zaman REMOVE komutu ile aynı özelliği gösterir.
            //Console.WriteLine(yenicumle);
            //Console.ReadLine();


            //***************TRIM / TRIMEND / TRIMSTART  *****************//

            //string cumle = "           Selam Nasılsın               ";
            //string yenicumle = cumle.TrimStart();//TRIM sağdaki ve soldaki boşlukların kendisini yok eder, TRIMEND kelime sonundaki boslukları yok eder, TRIMSTART ise kelime baslangıcındaki boslukları yok eder.
            //Console.WriteLine(yenicumle);
            //Console.ReadLine();




            //********************** TO LOWER *****************************//

            //string cumle = "SELAM ARKADAŞLAR";
            //string yenicumle = cumle.ToLower();
            //Console.WriteLine(yenicumle);
            //Console.ReadLine();


            //********************** TO UPPER *****************************//

            //string cumle = "selam arkadaşlar";
            //string yenicumle = cumle.ToUpper();
            //Console.WriteLine(yenicumle);
            //Console.ReadLine();


            //******************LENGHT*************************//

            //string cumle = "selam arkadaşlar";
            //int yenicumle = cumle.Length;//Girilen string'in karakter hesaplamasını yapar.
            //Console.WriteLine(yenicumle);
            //Console.ReadLine();


            //*************SPLIT********************************//

            //For döngüsü ile// 1. yol
            //string cumle = "çorba, pilav, fasulye";
            //for (int i = 0; i < cumle.Split(',').Length; i++)
            //{
            //    Console.WriteLine(cumle.Split(',')[i]);
            //}

            //Console.ReadLine();


            // 2.yol / Dizi Tanımlayarak Bölme
            string cumle = "Direnç-Aşkar-Nurettin-Armut";
            string[] dizi = cumle.Split('-');
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            Console.ReadLine();
        }

        //************** FORMAT ***********/////////

        //DateTime girdi;
        //string cikti;
        //girdi = DateTime.Now;
        //cikti = string.Format("{0:dddd}", girdi);
        //Console.WriteLine(cikti);
        //Console.ReadLine();

        // mm -dakika
        //yyyy - yılı verir
        // MM -Ayı verir (02)
        // MMMM -Ayı Verir (Şubat)
        //T - Saat (uzun format)
        //t - Saat (Kısa Format)
        // F - Tarih Saat 

        //// Decimal Format 
        //decimal girdi;
        //string cikti;
        //girdi = 15647455.545334m;
        //cikti = string.Format("{0:c}", girdi);
        //Console.WriteLine(cikti);
        //Console.ReadLine();
        // {0:C} 
        // "{0:C3}"
        //   "{0:F2}"
    }
    }
