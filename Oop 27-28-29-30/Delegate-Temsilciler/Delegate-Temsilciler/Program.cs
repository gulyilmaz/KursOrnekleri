using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Temsilciler
{
    class Program
    {
        /*---DElegate-Temsilciler
         * Aynı metot imzasına sahip olan methodları tutan ve liste içerinde barındıran yapılardır.Metod tutucu olarak ta bilinir.
         * Metod imzası:Hangi parametre alıyor ne donuyor bbuna bakar
         
         
         
         */
        delegate void Matematikselislemler(int sayi1, int sayi2);
      static  void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam işleminin sonucu : {0}",sonuc);

        }
        static void cikartma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkartma işleminin sonucu : {0}", sonuc);

        }
        static void carpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpım işleminin sonucu : {0}", sonuc);

        }


        static void Main(string[] args)
        {
            //Topla(10,20);
            //cikartma(20, 10);
            //carpma(10, 20);
            Matematikselislemler m1 = new Matematikselislemler(Topla);
            m1 += cikartma;
            m1 += carpma;

            m1.Invoke(30, 2);//metodları bu değerlerle çalıştırır.

            Delegate[] isaretedilenmetodlar = m1.GetInvocationList();
            foreach (var item in isaretedilenmetodlar)
            {
                Console.WriteLine(item.Method.Name);
            }
            m1 -= carpma;
            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }
            m1 -= cikartma;

            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }








            Console.ReadLine();


        }
    }
}
