using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personel> plist = new List<Personel>();
            for (int i = 1; i <=100; i++)
            {
                Personel p = new Personel();
                p.id = Guid.NewGuid();
                p.isim = FakeData.NameData.GetFirstName();
                p.soyisim = FakeData.NameData.GetSurname();
                p.EmailAdress = $"{ p.isim}.{p.soyisim}@{FakeData.NetworkData.GetDomain()}";
                p.telefonnumarasi = FakeData.PhoneNumberData.GetPhoneNumber();
                p.sehir = FakeData.PlaceData.GetCity();
                plist.Add(p);

            }
            Console.WriteLine("Bilgileriniz Json Formatında C:\\Jsonislemlerim\\personeller.json olarak kayıt edilecektir.");
            if (Directory.Exists("c:\\Jsonislemlerim\\"))
            {
                //varsa bişey yapma
            }
            else
            {
                Directory.CreateDirectory("c:\\Jsonislemlerim\\");
            }
            string jsonpersoneller = Newtonsoft.Json.JsonConvert.SerializeObject(plist);
            File.WriteAllText("c:\\Jsonislemlerim\\personeller.json", jsonpersoneller);
            Console.WriteLine("json export işlemi tamamlandı");
            Console.ReadLine();
        }
    }
}
