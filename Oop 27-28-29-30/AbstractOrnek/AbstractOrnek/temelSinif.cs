using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
   public abstract class temelSinif
    {
        public DateTime kayittarihi { get; set; }
        public DateTime guncellemetarih { get; set; }
        public temelSinif()
        {
            kayittarihi = DateTime.Now;
            guncellemetarih = DateTime.Now;
        }
        public void test()
        {
            Console.WriteLine("temelsınıf=>sınıf");
        }
        public abstract void testAbstract();//sadece metodun imzası yer alır
        //{

        //}

    }
}
