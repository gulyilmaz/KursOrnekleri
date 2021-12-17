using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNedir
{
    public class Musteri
    {
        /*
         * TCKimlik Numarası 
         * İsim
         * Soyisim 
         * Cinsiyet
         */
        public string TCkimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet; // 717770001 : Bay - 717770002 : Bayan
        // Yapıcı Metot ctor

        public Musteri()
        {

            //hiç dokunmazsam arkada boş çalışıyor default değeriyle oluşuyor

            //TCkimliknumara = "1234567890";--digerhalini ezdim bunu kullandım-- git bak bunu ver program csde
        }
        //birden fazla yapıcı metodum olabilir.
        public Musteri(string _tckimlikno)/*overload gibi kullanıcam*/
        {
            TCkimliknumara = _tckimlikno;
        }

        public Musteri(string _tckimlikno, string _isim)
        {
            TCkimliknumara = _tckimlikno;
            isim = _isim;

        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim)
        {
            TCkimliknumara = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;

        }

         //metod tanımı yapmaya geç

        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabase(TCkimliknumara);
            return kontrol;
        }

        private bool MusteriKontrolDatabase(string tckimlikNumarasi)
        {
            // database gidilir müşterinin tckimlik numarasına göre daha önce kayıt edilip edilmediği bilgisi sorgulanır... 
            return true;
        }
        //internal bu namespace içerinde public bunu örnekleyenler ulaşablr

    }
}
