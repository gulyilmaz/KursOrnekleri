using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimePersonel fltmp = new FullTimePersonel();
            fltmp.id = 100;
            fltmp.Ad = "metin";
            fltmp.Soyad = "şen";
            fltmp.YillikMaas = 40000;
            Console.WriteLine(fltmp.AdSoyad());
            Console.WriteLine("Full time maas="+fltmp.AylikMaas());

            SozlesmeliPersonel s = new SozlesmeliPersonel();
            s.id = 101;
            s.Ad = "melek";
            s.Soyad = "sapmaz";
            s.calismasuresi = 20;
            s.SaatlikOdeme = 40;
            Console.WriteLine(s.AdSoyad());
            Console.WriteLine("Sözlesmeli Personel Maaş="+s.AylikMaas());
            Console.ReadLine();


        }
    }
}
