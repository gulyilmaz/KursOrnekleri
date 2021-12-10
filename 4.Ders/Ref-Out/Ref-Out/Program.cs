using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 40, b = 60, max;
            buyuk(a, b, out max);
            Console.WriteLine("büyük sayı : {0}", max);
            int x = 5, c = 0;
            Console.WriteLine("Sayı= "+x);
            Console.WriteLine("Karesi="+ kare(x,out c));// return k ile kareyi getirir
            Console.WriteLine("Küpü= "+c);//gelirken cyi de getitiyor
            Console.ReadLine();
        }
        private static int kare(int a,out int b)
        {
            int k;
            k = a * a;
            b = a * a * a;
            return k;
        }
        private static void buyuk(int x, int y, out int b)
        {   if (x > y)
                b = x;
            else
                b = y;

        }
    }
}
