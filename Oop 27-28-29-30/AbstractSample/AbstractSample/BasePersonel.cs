using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
  public abstract  class BasePersonel
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AdSoyad()
        {
            return Ad + " " + Soyad;
        }
        public abstract int AylikMaas();
    }
}
