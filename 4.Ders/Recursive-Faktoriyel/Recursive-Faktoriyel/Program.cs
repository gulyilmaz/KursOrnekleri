using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            //0!=1
            //n-(n-1)!
            int i = 10;
            Console.WriteLine($"10 sayısının faktöriyeli {faktoriyel(i)}");
            Console.ReadLine();
        }
        static  int faktoriyel(int n)
        {
            if(n==0)
            { return 1; }
            return n * faktoriyel(n - 1);
        }
    }
}
