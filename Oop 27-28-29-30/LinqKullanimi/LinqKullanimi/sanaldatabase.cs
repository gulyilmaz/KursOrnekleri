using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqKullanimi
{
   public class sanaldatabase
    {
        List<Musteri> musteriler;
        public sanaldatabase()
        {
            musteriler = new List<Musteri>();
        }
        public List<Musteri> MusteriListesi()
        {

            for (int i = 1; i <= 1000; i++)
            {
                Musteri m = new Musteri();
                m.MusteriNo = i;
                m.isim = FakeData.NameData.GetFirstName();
                m.soyisim = FakeData.NameData.GetSurname();
                m.il = FakeData.PlaceData.GetCity();
                m.ilce = FakeData.PlaceData.GetStreetName();
                m.ulke = FakeData.PlaceData.GetCountry();
                m.DogumTarihi = FakeData.DateTimeData.GetDatetime(new DateTime(1990, 01, 01), new DateTime(1999, 01, 01));
                m.telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                m.email = $"{m.isim.ToLower()}.{m.soyisim.ToLower()}@{FakeData.NetworkData.GetDomain()}";
                musteriler.Add(m);
            }
            return musteriler;
        }

    }
}
