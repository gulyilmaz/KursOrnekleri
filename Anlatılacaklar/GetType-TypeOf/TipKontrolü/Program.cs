using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace TipKontrolü
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir değer giriniz");

            veriTipiBul(Console.ReadLine());
            Console.ReadLine();
        }

        public static void veriTipiBul(object Veri)
        {

            if (Veri is int)Console.WriteLine($"{Veri} verisinin tipi int");
            if (Veri is string) Console.WriteLine($"{Veri} verisinin tipi string");
            if (Veri is double) Console.WriteLine($"{Veri} verisinin tipi double");
           
        }
    }
}
