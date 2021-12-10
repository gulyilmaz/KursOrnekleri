using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeFonksiyonlari
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman = DateTime.Now;
           //Console.WriteLine(zaman);
            //Console.WriteLine(zaman.ToShortDateString());
            //Console.WriteLine(zaman.ToLongDateString());

            //DateTime zaman = DateTime.Now;
            //Console.WriteLine(zaman.ToLongTimeString());
            //Console.WriteLine(zaman.ToLongTimeString());
            //Console.WriteLine(zaman.ToShortTimeString());

            //Console.WriteLine(zaman.Hour);
            //Console.WriteLine(zaman.Minute);
            //Console.WriteLine(zaman.Second);
            //Console.WriteLine(zaman.Millisecond);
            //Console.Write("------\n");
            //Console.WriteLine(zaman.Day);
            //Console.WriteLine(zaman.Month);
            //Console.WriteLine(zaman.Year);

            //Console.WriteLine(zaman.AddDays(1));
            //Console.WriteLine(zaman.AddYears(-2));
            //Console.WriteLine(zaman.AddMonths(2));

            //Console.WriteLine(zaman.AddHours(2).ToLongTimeString());
            //Console.WriteLine(zaman.AddMinutes(-10).ToLongTimeString());
            //Console.WriteLine(zaman.AddSeconds(40).ToLongTimeString());

           // Console.WriteLine(DateTime.DaysInMonth(2004,2));

          //  Console.WriteLine(DateTime.IsLeapYear(2020));

            DateTime gun =DateTime.Now;
            DateTime yilbasi = new DateTime(2022, 1, 1);
            TimeSpan Span = yilbasi.Subtract(gun);
            Console.WriteLine(Span);
            Console.WriteLine("Yeni Yıla {0} gün var", Span.TotalDays);
            Console.WriteLine("Yeni Yıla {0} gün var", Span.Days);







            Console.ReadLine();
        }
    }
}
