using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_ErisimBelirleyiciler_
{
 public   class Kisi
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        protected int tc { get; set; }
       protected internal int Kredikartno { get; set; }


    }
}
