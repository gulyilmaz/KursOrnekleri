using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    public class musteri : temelSinif
    {
        public int musteriId { get; set; }
        public musteri()
        {
            musteriId=1;
        }
        public override void testAbstract()
        {
            Console.WriteLine("musteri=>testabstract");
        }
    }
}
