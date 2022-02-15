using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiilTabloOlusturma.Models
{
    public class Firma
    {
        public int Anahtar { get; set; }
        public string Unvan { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Adres { get; set; }
        public string EmailAdres { get; set; }
        public string FirmaLisansKey { get; set; }
        public ICollection<Personel> personeller { get; set; }
    }
}
