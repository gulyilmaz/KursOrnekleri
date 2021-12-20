using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme_ders
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Field değer ataması yapılamasın ama değer okunabilsin.
            * * Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin. 
            * Field değer ataması yapılsın ama değer okunamasın. 
            * Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.
            
            */

            // Class 
            //  Field 
            //  Property
            //  Get & Set 
            Musteri m = new Musteri();
            m.isim = "yılmaz";
            m.soyisim = "gül";
           
          
            Console.WriteLine(m.email);
            //m.tckimlik = "dff";
            //Console.WriteLine(m.tckimlik);///okunmaz hata verir
            //m.tckimlik = "50179695170";
            //Console.WriteLine(m.tckimlik);//yıldızlamayı göster
            Console.WriteLine("tc gir");
            m.tckimlik = Console.ReadLine();
            Console.WriteLine(m.tckimlik);
            Console.ReadLine();
        }
    }
}
