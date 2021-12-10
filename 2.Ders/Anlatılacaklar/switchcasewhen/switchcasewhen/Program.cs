using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcasewhen
{
    class Program
    {
        static void Main(string[] args)
        {// yer tanımlamayı göster YenidenSor:
            Console.WriteLine("Doğum yılınızı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int yas = DateTime.Now.Year - a;
            switch (yas)
            {
                case int kontrol when yas > 18:
                    Console.WriteLine($"Yaşınız {yas} Ehliyet alabilirsiniz");
                    break;

                case int kontrol when yas < 18:
                    Console.WriteLine($"Yaşınız {yas} Ehliyet alamazsınız");

                    //goto YenidenSor;
                    break;
                default:
                    
                    break;
            }
            Console.ReadLine();
        }
    }
}
