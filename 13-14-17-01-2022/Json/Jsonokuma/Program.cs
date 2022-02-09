using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jsonokuma
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonokunandata = File.ReadAllText("c:\\Jsonislemlerim\\personeller.json");
          List<Xobject> data=  Newtonsoft.Json.JsonConvert.DeserializeObject<List<Xobject>>(jsonokunandata);
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);

            }
            Console.ReadLine();
        }
    }
}
