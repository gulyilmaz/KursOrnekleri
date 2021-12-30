using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.id = 1;
            m1.isim = "gül";
            m1.soyisim = "yılmaz";

            MusteriGeneric<int> musterigeneric1 = new MusteriGeneric<int>();
            musterigeneric1.id = 1;
            musterigeneric1.musteriNumarasiAl();

            MusteriGeneric<Guid> musteriGeneric2 = new MusteriGeneric<Guid>();
            musteriGeneric2.musteriNumarasiAl();

        }
    }
}
