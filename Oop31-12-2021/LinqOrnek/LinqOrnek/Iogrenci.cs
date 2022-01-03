using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOrnek
{
    interface Iogrenci
    {
        int OgrenciNo { get; set; }
        string Ad { get; set; }
        string SoyAd { get; set; }
        double sinav1 { get; set; }
        double sinav2 { get; set; }
        double ortalama { get; set; }
        double Ortalama();
    }
}
