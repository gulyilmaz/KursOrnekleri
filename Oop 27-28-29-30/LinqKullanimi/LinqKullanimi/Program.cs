using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqKullanimi
{
    class Program
    {
       static List<Musteri> musteriliste = new List<Musteri>();
     static   sanaldatabase db = new sanaldatabase();
     
        
        static void Main(string[] args)
        {
            musteriliste = db.MusteriListesi();

            Console.WriteLine(musteriliste.Count());
            // isminin baş harfi A ile başlayan musterilerin adedi

            int bulunan = 0;

            for (int i = 0; i < musteriliste.Count; i++)
            {
                if(musteriliste[i].isim[0]=='A')
                {
                    bulunan++;
                }

            }

            Console.WriteLine("a ile başlayanların sayısı"+bulunan);
            Console.WriteLine(musteriliste.Count);

            //Linq Tekonolojisi
            bulunan = 0;
            bulunan = musteriliste.Where(x => x.isim.StartsWith("A")).Count();

            Console.WriteLine("a ile başlayanların sayısı" + bulunan);
            Console.WriteLine(musteriliste.Count);

            //Linq Sorgulama Çeşitleri
            int toplammusteri = musteriliste.Where(i => i.isim.EndsWith("A")).Count();

            var bulunanmusteri = from I in musteriliste
                                 where I.isim.EndsWith("A")
                                 select I;

            int bulananmusteri2 = bulunanmusteri.Count();

            //1:müşteriler içerisinde ülke değeri A ile başlayan musterileri linq teknolojisi ile getir

            int aisim=musteriliste.Where(i => i.isim.StartsWith("A")).Count();
            var aaisim = from I in musteriliste
                         where I.isim.StartsWith("A")
                         select I;


            //2:musterilr içersindeki kayıtlardan isminin içinde b harfi geçen ve ülke değeri içinde A harfi gecen  müsteri listesini getirin

            int aa = musteriliste.Where(x=> x.isim.ToLower().Contains("b") && x.ulke.ToLower().Contains("a")).Count();
            // ToLower() kullanılmasının sebebi Fakedata'dan çektiğimiz isim ve ülke adlarının baş harfi büyük harf ile başlıyor. Contains kullanımında "a" yada "A" olarak arama yaptığımızda bulmama ihtimalinden dolayı tüm kelimeyi küçük yada büyük harflere çevirdik.

            //3:musteriler listesi içerindeki kayılardan doğum yılı 1990dan büyük olan ve isminni içerisnde A gecen kayıtları Linq query yöntemiyle getirin.
            var bb = from A in musteriliste
                     where A.DogumTarihi.Year > 1990 && A.isim.ToLower().Contains("a")
                     select A;


            // Sorgulama işleminde Func Delegate Kullanımı
            var Delegatekullanimi = musteriliste.Where(x => x.isim.StartsWith("A"));

            Func<Musteri, bool> FuncDelegate = new Func<Musteri, bool>(FuncDeleagatekullanimi1);

            var Delegatekullanimi2 = musteriliste.Where(FuncDeleagatekullanimi1);

            var Delegatekullanimi3 = musteriliste.Where(new Func<Musteri, bool>(FuncDeleagatekullanimi1));

            var Delegatekullanimi4 = musteriliste.Where(delegate (Musteri m) { return m.isim[0] == 'A' ? true : false; });

            var Delegatekullanimi5 = musteriliste.Where((Musteri m) => { return m.isim[0] == 'A' ? true : false; });

            var Delegatekullanimi6 = musteriliste.Where((m) => { return m.isim[0] == 'A' ? true : false; });

            var Delegatekullanimi7 = musteriliste.Where(m => m.isim[0] == 'A');//Linq 



            //Predicate Delegate

            Predicate<Musteri> predicate = new Predicate<Musteri>(Predicatekullanimi);
            var predicatekullanimi1 = musteriliste.FindAll(predicate);

            var predicatekullanimi2 = musteriliste.FindAll(new Predicate<Musteri>(Predicatekullanimi));

            var predicatekullanimi3 = musteriliste.FindAll(delegate (Musteri m) { return m.DogumTarihi.Year > 1990; });

            var predicatekullanimi4 = musteriliste.FindAll((Musteri m) => { return m.DogumTarihi.Year > 1990; });

            var predicatekullanimi5 = musteriliste.FindAll((m) => { return m.DogumTarihi.Year > 1990; });

            var predicatekullanimi = musteriliste.FindAll(m => m.DogumTarihi.Year > 1990);



            //Action Delegate 
            Action<Musteri> actiondelegate = new Action<Musteri>(musterilistesi);

            musteriliste.ForEach(actiondelegate);

            musteriliste.ForEach(new Action<Musteri>(musterilistesi));

            musteriliste.ForEach(delegate (Musteri m)
            {
                Console.WriteLine(m.isim + " " + m.soyisim);
            });

            musteriliste.ForEach((Musteri m) =>
            {
                Console.WriteLine(m.isim + " " + m.soyisim);
            });


            musteriliste.ForEach(m =>
            {
                Console.WriteLine(m.isim + " " + m.soyisim);
            });





            Console.ReadLine();

        }
        static void musterilistesi(Musteri m)
        {
            Console.WriteLine(m.isim + " " + m.soyisim);
        }


        static bool Predicatekullanimi(Musteri m)
        { if(m.DogumTarihi.Year>1990)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool FuncDeleagatekullanimi1(Musteri m)
        { 
            if (m.isim[0]=='A')
            {
                return true;
            }
            else {return false; }
        }
    }
}
