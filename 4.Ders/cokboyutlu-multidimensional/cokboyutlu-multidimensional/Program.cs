using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cokboyutlu_multidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] bolgeler = new string[7, 3]
            {
                {"İstanbul ","Tekirdağ","Bursa"},
                {"İzmir","Manisa","Muğla" },
                {"Antalya","Isparta","Mersin" },
                {"Konya","Ankara","Eskişehir" },
                {"zonguldak","Rize","Trabzon" },
                {"Gaziantep","mardin","urfa" },
                {"ağrı","hakkari","van" },

            };

            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);
                }
                Console.WriteLine("************");
            }
            Console.ReadLine();


            ;

        }
    }
}
