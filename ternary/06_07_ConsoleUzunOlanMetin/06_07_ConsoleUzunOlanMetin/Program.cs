using System;
using static System.Console;

namespace _06_07_ConsoleUzunOlanMetin
{
 class Program
 {
  static void Main(string[] args)
  {
   string ilkMetin, sonMetin;
   Write("İlk Metni Giriniz: ");
   ilkMetin = ReadLine();
   Write("Son Metni Giriniz: ");
   sonMetin = ReadLine();
            Console.Write(sonMetin.Length < ilkMetin.Length ? $"İlk metin uzun {ilkMetin.Length} karakter var." : $"İkinci metin uzun {sonMetin.Length} karakter var.");


   
   ReadKey();
  }
 }
}
