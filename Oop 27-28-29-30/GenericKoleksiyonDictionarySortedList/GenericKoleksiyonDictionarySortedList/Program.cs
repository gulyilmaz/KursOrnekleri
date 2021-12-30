using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonDictionarySortedList
{
    class Program
    {
        static void Main(string[] args)
        {//Generic olmayan koleksiyon davranışı
            Hashtable h1 = new Hashtable();
            h1.Add(1, "bir");
            h1.Add(2, "iki");
            h1.Add(3, true);
            //  h1.Add(1, "test");

            //Dictionary<Tkey,Tvalue>
            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "deneme");
            DictionaryList.Add(2, "deneme2");
            DictionaryList.Add(3, "deneme");
            //  DictionaryList.Add(1, "deneme3");
       // bool silmesonuc=  DictionaryList.Remove(1);
            //if(silmesonuc)
            //{
            //    Console.WriteLine("silindi");
            //}
            //else
            //{
            //    Console.WriteLine("aranan değer list içerinde bulunamadı");
            //}
           

            bool aranandeger = DictionaryList.ContainsKey(1);
            if(aranandeger)
            {
                string gelendeger = DictionaryList[1];
                gelendeger = "yenilenen değer";
                DictionaryList[1] = gelendeger;
            }
            else
            {
                Console.WriteLine("aranan değer bulunamadı");
            }

            bool aranandegerv = DictionaryList.ContainsValue("deneme2");
            if(aranandegerv)
            {
                Console.WriteLine( "aranan değer bulundu");
            }
            else
            {
                Console.WriteLine("aranan değer bulunamadı");
            }

            foreach(KeyValuePair<int,string> item in DictionaryList)
            {

                Console.WriteLine("Anahtar: {0} || Değer: {1}",item.Key,item.Value);
            }
            DictionaryList.Clear();

            SortedList<int, string> sortedlistkoleksiyon = new SortedList<int, string>();
            sortedlistkoleksiyon.Add(100, "yüz");
            sortedlistkoleksiyon.Add(50, "elli");
            sortedlistkoleksiyon.Add(1, "bir");
            sortedlistkoleksiyon.Add(1000, "bin");
         




            Console.ReadLine();
        }
    }
}
