using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProje
{
    public class KupKutu : IUrun
    {
        public int Id { get ; set ; }
        public string UrunAd { get ; set; }
        public int yukseklik { get ; set  ; }

        public int Hacim()
        {
            double hacim = Math.Pow(Convert.ToDouble(yukseklik), 3);
            return Convert.ToInt32(hacim);
        }
    }
}
