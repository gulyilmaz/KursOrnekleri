using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstKisiler.Models.Manager
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Kisiler> Kisiler { get; set; }
        public DbSet<Adres> Adresler { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new Veritabanıolusturucu());
        }
    }
    public class Veritabanıolusturucu : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                Kisiler kisi = new Kisiler()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                     Yas=FakeData.NumberData.GetNumber(10,80),
                    
                };
                context.Kisiler.Add(kisi);

            }
            context.SaveChanges();
            List<Kisiler> tumkisiler = context.Kisiler.ToList();

            foreach (var kisi in tumkisiler)
            {
                for (int i = 0; i < FakeData.NumberData.GetNumber(1,5); i++)
                {
                    Adres adres = new Adres();
                    adres.AdresTanim = FakeData.PlaceData.GetAddress();
                    adres.Kisiler = kisi;
                    context.Adresler.Add(adres);

                }

            }
            context.SaveChanges();



        }
    }
}