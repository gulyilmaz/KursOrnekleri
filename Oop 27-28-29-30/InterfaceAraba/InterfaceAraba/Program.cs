using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAraba
{
    class Program
    {
        static void Main(string[] args)
        {
            ArabaSinifi a = new ArabaSinifi();
            a.Marka = "Cabby";
            a.Model = "Minibüs";
            a.Modelyili = 2004;
            a.sanziman = "Otomatik";
            a.yildiz = 8;
            a.OzellikOku();
            Console.ReadLine();
        }
    }
}
