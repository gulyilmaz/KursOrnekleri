using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulproje
{
   public class ogrenci
    {
        public int Id { get; set; }
        public string Ad { get => _Ad; set => _Ad = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower(); }
        public string Soyad { get => _Soyad; set => _Soyad = value.ToUpper(); }

        private string _Ad;
        private string _Soyad;

    }
}
