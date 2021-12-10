using System;
using  static System.Console;
using static System.Convert;

namespace _06_06_Console5tenBuyukmu
{
 class Program
 {
  static void Main(string[] args)
  {
   Write("Bir sayı giriniz:");
   int i = ToInt32(ReadLine());
   string sbt = "Rakam 5’";
   Write(i == 5 ? sbt + "tir" : i < 5 ? sbt + "ten küçük" : sbt + "ten büyük");
   ReadLine();
  }
 }
}
