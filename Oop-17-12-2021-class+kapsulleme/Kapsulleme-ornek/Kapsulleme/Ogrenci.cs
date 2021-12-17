using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class Ogrenci
    {
        private string _Ad;

        public string Ad
        {
            get { return _Ad; }
            set { _Ad = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower() ; }
        }
        private string _Soyad;

        public string Soyad
        {
            get { return _Soyad; }
            set { _Soyad = value.ToUpper(); }
        }
        private long _TCKimlik;

        public long TCKimlik
        {
            get { return _TCKimlik; }
            set { _TCKimlik = Math.Abs(value); }
        }
    }
}
