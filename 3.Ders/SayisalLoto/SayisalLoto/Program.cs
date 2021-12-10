using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] sayi = new int[6];
            string sayistr = "";
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                int rastgelesayi= rnd.Next(1, 50);
                if(!sayistr.Contains(rastgelesayi.ToString()))
                { sayistr = $"{sayistr} {rastgelesayi}";
                    sayi[i] = rastgelesayi;
                }
               
            }
            Console.WriteLine(sayistr);
            Array.Sort(sayi);
            foreach (int item in sayi)
            {
                Console.Write(item+ " ");
            }
         
            Console.ReadLine();
        }
    }
}
