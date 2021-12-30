using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateisimsizmetodkullanimi
{
    delegate void EkranaYaz(string a, string s);
    class Program
    {
        static void Main(string[] args)
        {
            //Var olan bir metodu kullanarak delagate içine ekleme
            EkranaYaz test1 = new EkranaYaz(TestMetod);

            test1("gül", "yılmaz");
            //İsimsiz metod kullanımı
            EkranaYaz test2 = new EkranaYaz(delegate (string a, string s)
              {
                  Console.WriteLine(a + " " + s);
              });
            test2("semra", "mert");

            ////Lamda Exp Kullanımı
            EkranaYaz test3 = (a, s) =>
            {
                Console.WriteLine(a + " " + s);
            };
            test3("nuran", "kaya");


            Console.ReadLine();

        }
        static void TestMetod(string a,string s)
        {
            Console.WriteLine(a+ " " + s);
        }
    }
}
