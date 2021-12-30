using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
 public   interface Imusteri
    {
        //public Imusteri()
        //{

        //}//Interface te yapıcı metod kullanılmaz. Tamamen şablondur
        //field
        //değişken tanımlanmaz sadece property oluşturabilirim
        //interface örneklenmez.
        //clasıma birden fazla interfaceten miras alabilirim.
        int Id { get; set; }
        //Erişim belirleyicisi kullanamam
        string isim { get; set; }

        string soyisim { get; set; }

        int yenikayit(string isim, string soyisim);//metodun imzası yer alır
        int kayitduzenle(int id, string isim, string soyisim);
      
        /*
         
         Fromda datagridview yer alıcak
        Iurun isminde bir interface  içersinde id,ad,yukseklik propertyleri yer alıcak,hacim isiminde geri dönüşü int olan bir metod olucak
        Kupkutu ve Dıkdörtgen kutu isiminde iki class olucak bunlar Iurunden kalıtım alıcak
        dıkdörtgen için hacim formulu=yükseklik*kısakenar*uzunkenar,
        kupkutu için hacim=yukseklik*yukseklik*yukseklik

         
         */




    }
}
