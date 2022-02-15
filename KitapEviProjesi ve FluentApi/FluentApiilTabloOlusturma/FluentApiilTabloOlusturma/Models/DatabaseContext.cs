using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiilTabloOlusturma.Models
{
    public class DatabaseContext:DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {

        }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Suplier> Supliers { get; set; }
        public DbSet<SuplierProduct> SuplierProducts { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Firma>().ToTable("Tbl_Firma");
            modelBuilder.Entity<Personel>().ToTable("Tbl_Personel");
            modelBuilder.Entity<Firma>().Property(x => x.Unvan).HasColumnName("FirmaUnvan");
            //modelBuilder.Entity<Firma>().Property(x => x.ID).HasColumnName("Anahtar");
            modelBuilder.Entity<Firma>().HasKey(x => x.Anahtar);//Birincil anahtar tanımlama
            modelBuilder.Entity<Personel>().HasKey(x => x.Anahtar_Personel);
            modelBuilder.Entity<Personel>().Property(x => x.isim).HasColumnName("Ad");
            modelBuilder.Entity<Personel>().Property(x => x.Soyisim).HasColumnName("Soyad");

            modelBuilder.Entity<Personel>().Property(x => x.Telefon).HasColumnName("TelefonNumara");
            //Notmapped burdaki karşılığı
            modelBuilder.Entity<Firma>().Ignore(x => x.FirmaLisansKey);
            //required ın burda kullanımı
            modelBuilder.Entity<Personel>().Property(x => x.isim).IsRequired();//boş geçilemez
            //max lenght
            modelBuilder.Entity<Firma>().Property(x => x.Unvan).IsRequired().HasMaxLength(100);

            //bire çok ilişki tanımlama
            //modelBuilder.Entity<Personel>().HasOne(x => x.Firma).WithMany(x => x.personeller).HasForeignKey(x => x.firID);

            modelBuilder.Entity<Firma>().HasMany(x => x.personeller).WithOne(x => x.Firma).HasForeignKey(x => x.firID).OnDelete(DeleteBehavior.Cascade);
            //çoka çok ilişki tanımlama
            modelBuilder.Entity<SuplierProduct>().HasKey(x => new { x.ProductID, x.SupplierID });//composite key oluşturdum.
            modelBuilder.Entity<SuplierProduct>().HasOne(x => x.Product).WithMany(x => x.SuplierProducts).HasForeignKey(x => x.ProductID);
            modelBuilder.Entity<SuplierProduct>().HasOne(x => x.Suplier).WithMany(x => x.SuplierProducts).HasForeignKey(x => x.SupplierID);


            //birebir ilişki
            modelBuilder.Entity<Product>().HasOne(x => x.ProductDetails).WithOne(x => x.Product).HasForeignKey<ProductDetails>(x => x.prtID);
        }
    }
}
