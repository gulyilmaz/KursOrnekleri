﻿// <auto-generated />
using FluentApiilTabloOlusturma.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluentApiilTabloOlusturma.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220214085104_ekletabloprop")]
    partial class ekletabloprop
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FluentApiilTabloOlusturma.Models.Firma", b =>
                {
                    b.Property<int>("Anahtar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNumarasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvan")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirmaUnvan");

                    b.HasKey("Anahtar");

                    b.ToTable("Tbl_Firma");
                });

            modelBuilder.Entity("FluentApiilTabloOlusturma.Models.Personel", b =>
                {
                    b.Property<int>("Anahtar_Personel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyisim")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Soyad");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TelefonNumara");

                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ad");

                    b.HasKey("Anahtar_Personel");

                    b.ToTable("Tbl_Personel");
                });
#pragma warning restore 612, 618
        }
    }
}
