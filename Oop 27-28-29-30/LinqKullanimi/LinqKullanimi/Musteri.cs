using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqKullanimi
{
   public class Musteri
    {
        public int MusteriNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        public DateTime DogumTarihi { get; set; }
        public string ulke { get; set; }
        public string ilce { get; set; }
        public string il { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }

    }
}
