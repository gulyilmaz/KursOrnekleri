using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProje
{
   public interface IUrun
    {

         int Id { get; set; }
         string UrunAd { get; set; }
         int yukseklik { get; set; }
        int Hacim();

    }
}
