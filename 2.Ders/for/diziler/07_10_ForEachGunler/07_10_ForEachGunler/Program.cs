using static System.Console;

namespace _07_10_ForEachGunler
{
 class Program
 {
  static void Main(string[] args)
  {
   string[] HaftaninGunleri = { "Pazartesi", "Salı",
    "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
   foreach (string item in HaftaninGunleri)
   {
    WriteLine(item);
   }
   ReadKey();
  }
 }
}
