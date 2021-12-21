using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim_ders
{
    public class Temelinsan
    {
        public int Id { get; set; }
        public long tcno { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cins { get; set; }
        public Adres[] Adres;
        public Temelinsan()
        {
            Adres = new Adres[4];
        }
    }
}
