using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhiledongusu
{
    class Program
    {
        static void Main(string[] args)
        { //while(true)
          //{
          //    // kodlarımız çalış
          //}


            //do
            //{
            //    Console.WriteLine("do while Döngüsü");
            //}

            //while (1==2);

            //Console.ReadLine();

            // do while döngülerindeki en temel fark şartları ne olursa olsun 1 kere kesin çalışır. 




            #region 1 ile 100 arasındaki rakamları tek ve çift olmak üzere sıralayım.
            int sayac = 1;
            int cift = 0, tek = 0;
            do
            {
                //if(sayac%2==0)
                //    {
                //        cift += sayac;

                //    }
                //    else
                //    {
                //        tek += sayac;
                //    }

                Console.WriteLine(sayac % 2 == 0 ? sayac + ":cift" : sayac + "tek");
                cift = sayac % 2 == 0 ? cift + sayac : cift + 0;
                tek = sayac % 2 != 0 ? tek + sayac : tek + 0;

                sayac++;
            }
            while (sayac <= 100);
            Console.WriteLine(cift);
            Console.WriteLine(tek);



            Console.ReadLine();
            #endregion


        }
    }
}
