using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 10;

            degistir( x, y);
            Console.WriteLine($"x'in değeri={x}");
            Console.WriteLine($"y'in değeri={y}");
            Console.ReadLine();
        }
        static void degistir(int x, int y)
        {
            int gecici=x;
            x = y;
            y = gecici;
        }
    }
}
