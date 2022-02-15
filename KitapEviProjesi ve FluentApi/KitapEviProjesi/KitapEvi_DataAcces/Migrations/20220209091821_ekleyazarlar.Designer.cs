﻿// <auto-generated />
using System;
using KitapEvi_DataAcces.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KitapEvi_DataAcces.Migrations
{
    [DbContext(typeof(KitapEviContext))]
    [Migration("20220209091821_ekleyazarlar")]
    partial class ekleyazarlar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KitapEvi_Models.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAd")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ad");

                    b.HasKey("KategoriID");

                    b.ToTable("tb_Kategori");
                });

            modelBuilder.Entity("KitapEvi_Models.Models.Kitap", b =>
                {
                    b.Property<int>("KitapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YayineviID")
                        .HasColumnType("int");

                    b.HasKey("KitapID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("YayineviID");

                    b.ToTable("tb_Kitap");
                });

            modelBuilder.Entity("KitapEvi_Models.Models.Tur", b =>
                {
                    b.Property<int>("TurID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TurAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurID");

                    b.ToTable("Turler");
                });

            modelBuilder.Entity("KitapEvi_Models.Models.Yayinevi", b =>
                {
                    b.Property<int>("YayineviID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lokasyon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YayinEviAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YayineviID");

                    b.ToTable("tb_Yayinevi");
                });

            modelBuilder.Entity("KitapEvi_Models.Models.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dogumtarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lokasyon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarID");

                    b.ToTable("tb_Yazar");
                });

            modelBuilder.Entity("KitapEvi_Models.Models.Kitap", b =>
                {
                    b.HasOne("KitapEvi_Models.Models.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitapEvi_Models.Models.Yayinevi", "Yayinevi")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YayineviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Yayinevi");
                });

            modelBuilder.Entity("KitapEvi_Models.Models.Yayinevi", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
