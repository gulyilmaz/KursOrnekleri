using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAraba
{
  public  interface IAraba
    {
         string Marka { get; set; }
         string Model { get; set; }
         int Modelyili { get; set; }
         string sanziman { get; set; }
        void OzellikOku();

    }
}
