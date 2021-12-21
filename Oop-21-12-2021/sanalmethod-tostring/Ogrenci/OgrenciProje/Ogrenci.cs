using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProje
{
   public   class Ogrenci
    {
        public    int Id { get; set; }
        public     string  Ad { get; set; }
        public    string Soyad { get; set; }
        public  string AdSoyad { get; set; }
        public  string GetFulName()
        {
            return Ad + Soyad;
        }
        public Ogrenci()
        {
          this.AdSoyad =  this.Ad + this.Soyad;
        }
        public override string ToString()
        {
            return Ad + Soyad;
        }
    }
}
