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

            string[] isimler = new[] { "Selin", "Emre", "Deniz", "Ferhat", "Hatice" };
            foreach (string item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            
        }
    }
}
