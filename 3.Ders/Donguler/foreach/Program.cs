using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isim = { "Eda", "selin", "salih", "ayşe", "lale" };
            foreach(string item in isim)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            
        }
    }
}
