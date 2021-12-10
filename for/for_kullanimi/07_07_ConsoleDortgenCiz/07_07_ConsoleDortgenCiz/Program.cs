using static System.Console;
using static System.Convert;
using static System.Environment;

namespace _07_07_ConsoleDortgenCiz
{
 class Program
 {
  static void Main(string[] args)
  {
   Write("Dörtgenin En değerini yazınız:");
   int en = ToInt32(ReadLine());
   Write("Dörtgenin Boy değerini yazınız:");
   int boy = ToInt32(ReadLine());
   if (en != boy)
   {
    for (int i = 0; i < boy; i++)
    {
     for (int j = 0; j < en; j++)
     {
      Write("*");
     }
     Write(NewLine);
    }
   }
   else
   {
    Write("Kare seçtiniz.");
   }
   Read();
  }
 }
}
