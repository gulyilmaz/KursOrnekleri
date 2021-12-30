using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    class Program
    {
        static void Main(string[] args)
        {//Abstract Class:Kendimize işimize yarayacak bir model çıkarıyoruz.
            //Abstract sınıflar örneklenmez.Şablon olarak kullanılır.Kural kütüphanesidir.
            // ondan kalıtım alan sınıflar yapıcı metodunu çalıştırabilir.Ama program.cs de örneklenmez
          //temelSinif t = new temelSinif();

            //abstract olarak tanımlı metodları kullanmak zorunda bırakır eğer başında abstarct ifadesi yoksa implement etmeyi zorunlu kılmaz
            //abstract sınıflar sealed kullanılmaz.
            musteri m1 = new musteri();
            m1.test();
            m1.testAbstract();
            superMusteri sp = new superMusteri();
            sp.testAbstract();



          /*  3 tane class olucak
         ---   BasePersonel abstract class olucak içersinde AD,Id,Soyad properyleri olacak,AdSoyad isminde bir metod tanımlanacak bu geriye isim ve soy ismi birleştirip göndericek, AylıkMaas isminde abstract int geri değer donduren bir metod olacak
          --FulltimePersonel : basepersonelden kalıtım alıcak içerisnde yıllık maaş propertysi olcak, aylık maasş metodu hesaplanması yıllıkmaaş/12 olarak tanımlanıcak
          ---SözleşmeliPersonel: Basepersonelden kalıtımalıcak ,içerisinde  saatliködeme ve çalışma süresi adında int property yer alıcak.Aylık maas metodu saatlikodeme*calışmasüresi olarak hesaplanacak

          
           
           
           */

        }
    }
}
