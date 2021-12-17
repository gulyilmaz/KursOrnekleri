using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUret
{
    public class BAU
    {
        string[] Adlar = { "Şamil", "Cemal", "Ali", "Murat", "Kemal", "Şahin", "Hüseyin" };
        string[] Soyadlar = { "Yıldız", "Erkmen", "Kahraman", "Erdemir" };
        string[] Sehirler = { "Ankara", "İstanbul", "İzmir", "Eskişehir", "Adana" };
        static Random rnd = new Random();
        public string GetName()
        {
            int sayi = rnd.Next(0, Adlar.Length);
            return Adlar[sayi];
        }
        public string GetSurname()
        {

            int sayi = rnd.Next(0, Soyadlar.Length);
            return Soyadlar[sayi];
        }
        public string City()
        {

            int sayi = rnd.Next(0, Sehirler.Length);
            return Sehirler[sayi];
        }
        public DateTime GetBackDate(int year)
        {
            year = -1 * rnd.Next(0, year);
            return DateTime.Now.AddYears(year);
        }
        public DateTime GetForwardDate(int year)
        {
            year = rnd.Next(0, year);
            return DateTime.Now.AddYears(year);
        }
    }
}
