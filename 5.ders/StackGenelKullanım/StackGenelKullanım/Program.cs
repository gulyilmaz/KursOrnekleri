using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGenelKullanım
{
    class Program
    {
        static void Main(string[] args)
        {
             Stack S1 = new Stack();

            S1.Push("Bir");
            S1.Push("İki");
            S1.Push("Üç");
            S1.Push("Dört");

            object O1 = S1.Pop();//DEtayı bana gönderdi ve listeden çıkardı
            object O2 = S1.Peek();//detayı gönderir lsteden çıkarmzz
            Console.WriteLine(O1);
        }
    }
}
