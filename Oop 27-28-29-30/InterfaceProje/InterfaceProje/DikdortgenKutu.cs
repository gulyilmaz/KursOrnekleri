using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProje
{
    public class DikdortgenKutu : IUrun
    {
        public int Id { get ; set ; }
        public string UrunAd { get ; set ; }
        public int yukseklik { get ; set ; }
        public int Kisakenar { get; set; }
        public int UzunKenar { get; set; }
        public int Hacim()
        {
            return yukseklik * Kisakenar * UzunKenar;
        }
    }
}
