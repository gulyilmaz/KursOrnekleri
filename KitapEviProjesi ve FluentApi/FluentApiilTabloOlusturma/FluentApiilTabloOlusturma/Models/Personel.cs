using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiilTabloOlusturma.Models
{
    public class Personel
    {
        public int Anahtar_Personel { get; set; }
        public string isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }
        public string Telefon { get; set; }
        public string Aciklama { get; set; }
        public int firID { get; set; }
        public Firma Firma { get; set; }

    }
}
