using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5,b=12;
            Program prg = new Program();
           prg.saatkac();
            Console.WriteLine( prg.ToplamAl(a,b));
            Console.ReadLine();

        }

        private void saatkac()
        {
            Console.WriteLine( DateTime.Now);

        }

        private int ToplamAl(int a,int b)
        {
            return a + b;
        }
    }
}
