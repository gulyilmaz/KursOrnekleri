using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOrnek
{
    public class Ogrenci : Iogrenci
    {
      
        public Ogrenci()
        {
           
        }
        private int _OgrenciNo;
        public int OgrenciNo { get
            
                //Random rnd = new Random();
                //_OgrenciNo = rnd.Next(1000, 2000);
                //return _OgrenciNo
                    ;
             set 

              
                ;  }
        public string Ad { get ; set; }
        public string SoyAd { get ; set; }
        public double sinav1 { get ; set ; }
        public double sinav2 { get ;set; }
        public double ortalama { get ; set ; }

        public double Ortalama()
        {
            return (sinav1 + sinav2) / 2;
        }
    }
}
