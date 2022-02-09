using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jsonokuma
{
   public class Xobject
    {
        public Guid id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string EmailAdress { get; set; }
        public string telefonnumarasi { get; set; }
        public string sehir { get; set; }

        public override string ToString()
        {
            return isim +" "+ soyisim+" "+EmailAdress;
        }
    }
}
