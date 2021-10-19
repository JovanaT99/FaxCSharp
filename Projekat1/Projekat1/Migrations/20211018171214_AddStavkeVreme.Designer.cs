﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekat1;

namespace Projekat1.Migrations
{
    [DbContext(typeof(BazaContext))]
    [Migration("20211018171214_AddStavkeVreme")]
    partial class AddStavkeVreme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Projekat1.Artikal", b =>
                {
                    b.Property<int>("ArtikalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cena")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mera")
                        .HasColumnType("TEXT");

                    b.Property<string>("Naziv")
                        .HasColumnType("TEXT");

                    b.HasKey("ArtikalId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Artikli");
                });

            modelBuilder.Entity("Projekat1.Kategorija", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ime")
                        .HasColumnType("TEXT");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorije");
                });

            modelBuilder.Entity("Projekat1.Stavka", b =>
                {
                    b.Property<int>("StavkaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtikalId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Cena")
                        .HasColumnType("REAL");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Kolicna")
                        .HasColumnType("REAL");

                    b.Property<long>("Vreme")
                        .HasColumnType("INTEGER");

                    b.HasKey("StavkaId");

                    b.HasIndex("ArtikalId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Stavke");
                });

            modelBuilder.Entity("Projekat1.Artikal", b =>
                {
                    b.HasOne("Projekat1.Kategorija", "Kategorija")
                        .WithMany("Artikli")
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategorija");
                });

            modelBuilder.Entity("Projekat1.Stavka", b =>
                {
                    b.HasOne("Projekat1.Artikal", "Artikal")
                        .WithMany()
                        .HasForeignKey("ArtikalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekat1.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artikal");

                    b.Navigation("Kategorija");
                });

            modelBuilder.Entity("Projekat1.Kategorija", b =>
                {
                    b.Navigation("Artikli");
                });
#pragma warning restore 612, 618
        }
    }
}
