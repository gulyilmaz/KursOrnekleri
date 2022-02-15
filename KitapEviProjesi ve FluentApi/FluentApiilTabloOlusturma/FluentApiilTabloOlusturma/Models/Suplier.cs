using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiilTabloOlusturma.Models
{
    public class Suplier
    {
        public int SuplierID { get; set; }
        public string Name { get; set; }
        public int City { get; set; }
        public ICollection<SuplierProduct> SuplierProducts { get; set; }
    }
}
