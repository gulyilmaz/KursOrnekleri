using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema
{
    class Program
    {
        public static int koltuksecim=0;
        public static string isimg ;
        public static int[] koltuk={0,1,2,3,4,5,6,7};
        public static string[] isim={"","","","","ahmet","","",""};
        static int sayac;
        static void Main(string[] args)
        {if (sayac == 0)
            {
                foreach (var item in isim)
                {
                    if(item!="")
                    { sayac++; }
                }
            }
            if (sayac == koltuk.Length)
            { Console.WriteLine("bilet alamazsınız");
                Console.ReadLine();
            }
            else
            {
                isimal();
                koltukkontrol();
                rezervasyon();
                Main(null);
            }
        }
        public static void isimal()
        {
            Console.WriteLine("LUTFEN ADINIZI GIRINIZ:");
            isimg = Console.ReadLine();
            for(int i=0;i<isimg.Length;i++)
            {
                if(char.IsDigit(isimg[i])==true)
                {
                    isimal();
                }
            }
        }
        public static void koltukkontrol()
        {
            int sayac = 1;
            for (int i = 0; i < isim.Length; i++)
             
            {
                if(isim[i]=="")
                {
                    
                    Console.WriteLine("{0}.KOoltuk Boş", i);
                   
                }
                else
                {
                    Console.WriteLine("{0}koldtuk {1} tarafından  dolu", i,isim[i]);

                   
                }
              
                
            }
            if (sayac == koltuk.Length)
            {
                Console.WriteLine("Salon dolu");
            }
            else if (sayac != koltuk.Length)
            {
                Console.WriteLine("Salon boş");
            }
        }

        public static void rezervasyon()
        {
            try
            {
                Console.WriteLine("İstediğiniz koltuğu seçiniz");
                koltuksecim = Convert.ToInt32(Console.ReadLine());
                if (isim[koltuksecim] == "")
                {
                    isim[koltuksecim] = isimg;
                    sayac++;
                }
                else
                {
                    Console.WriteLine("sectigin koltuk dolu");
                    rezervasyon();
                }
                Console.WriteLine("{0}.koltuk {1} rezerve edilmiştir", koltuk[koltuksecim], isim[koltuksecim]);
                koltukkontrol();
            }
            catch(IndexOutOfRangeException) 
            {
                Console.WriteLine("OLMAYAN KOLTUK SECİMİ");
                rezervasyon();
                
            }
            
           
        }
        

    }
}
