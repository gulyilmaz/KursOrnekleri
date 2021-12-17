using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //ikinci el araç satışı yapan bir firmam var ve şirketn temel süreçlerinin takibini istedi
            //müşteri*-tec,isim,soyisim,cinsiyet vb
            //satış temsilcisi--tc,sicilnumarası,isim,soyisim,cinsiyet vb
            //araç marka model model yıl km yakıt türü vb
            //teklif teklif numarası müşteri satıcı ürün fiyat vb
            //sipariş sipariş no teklif fiyat
            //fatura fatura no teklif müşteri vb
            // f12 ile stringe git


            //Musteri M1 = new Musteri();  //sistemde nesnemi örnekledim.
            //m1 deki tanımlarda public olmayınca ulaşamadım.

            //m1.isim = "gül";
            //m1.soyisim = "yılmaz";
            //m1.cinsiyet = 711771002;

            //ben bu yapıyı çalıştırdığımda nasıl işleyecek

            /*
             
             breakle içine gir new lenmeden önceki hali null 

            
            Musteri M2 = M1; m2 de aynı yere baksın dedim
            pointle bak
            M2.isim = "Murat";m2de baktığı alanı değiştrdiğimde m1 dedğişti.aynı yere bakıyor o güncellemeti ikisi de görür.referans tipi davranışın mantığı buydu
              M1.TCkimliknumara = "12254401325";
            
            //M2 = null;
            //M1 = null;
              //string isim = M2.isim;
            bellekten düşma nasıl oluyor.
            m2 sen artık burayı gösterme.m2 de artık null var ama değerim hala heap bölgede m1den ulaşırım . ama m1 de boş olursa artık onu tutan bir şey yok heap bölgede pointersız kalırsa ram den düşer  garbage collector alır bunu siler.
             //string isim = M2.isim; bunu çalıştırmak istersem hata alırım bu şu demek m2 nin müşteri nesnesi olduğunu biliyorum new ile açmadığım için buna ulaşamkyrum diyor

            Musteri M1 = new Musteri(); bu parantez sen bana git varsayılan değerle oluştur demek bu noktada çalışan bir metot var müşteri cs ye geç


              M1.TCkimliknumara = "12254401352";  benim verdiğim değere sahip oldu
             */
            //overload ı burdan göster f11le detaya in hangi overloda gitti bak
            Musteri M1 = new Musteri("122544013254", "Murat");
            M1.TCkimliknumara = "12254401352";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.cinsiyet = 717770001;
            

            Musteri M2 = M1;

            M2.isim = "Murat";
            M1.TCkimliknumara = "12254401325";




            //M2 = null;
            //M1 = null;

            //string isim = M2.isim;
            bool musteriKontrol = M1.MusteriKontrol();

            #region Araç Sınıfı İnceleme 
            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);
            A1.AlisFiyat = 28000;
            A1.SatisFiyat = 32000;
            A1.MaxIndirimTutar = 1500;
            // A1.Fiyat = Kapsülleme konusu ....
            A1.FiyatAta(31000);
            A1.BilgileriGoruntule();
            #endregion

         
            Console.ReadLine();

        }
    }

    //class Musteri
    //{böylede tanımlarım

    //}

}

