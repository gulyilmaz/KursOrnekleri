using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Party
{
    class Program
    {
        public static string Yazi = "";
        static void Main(string[] args)
        {

         //   GetParty(T);
            GetParty(true, "Esrar");
         //  GetParty(false, "Çay");
            Console.WriteLine(Yazi);
            Console.ReadKey();
        }
        public static string GetParty(bool Party)
        {
            if (Party == true)
            {
                return Yazi = "İyi Eğlenceler";
            }

            else
            {
                return Yazi = "Üzgünüm Parti Yok";
            }
        }

        public static string GetParty(bool Party, String PartiAdi)
        {
            if (Party == true)
            {
                return Yazi = PartiAdi + " " + "Partisinde" + " " + "İyi Eğlenceler dilerim ";

            }

            else
            {
                return Yazi = PartiAdi +" "+ "Partisi İptal oldu";
            }

        }

    }

}

