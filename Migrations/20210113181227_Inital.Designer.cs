﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Perpustakaan.Data;

namespace Perpustakaan.Migrations
{
    [DbContext(typeof(PerpustakaanContext))]
    [Migration("20210113181227_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Perpustakaan.Models.Anggota", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("kode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notelp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tm_anggota");
                });

            modelBuilder.Entity("Perpustakaan.Models.Buku", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("judul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tm_buku");
                });

            modelBuilder.Entity("Perpustakaan.Models.Pinjam", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("anggota_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("buku_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tt_pinjam");
                });
#pragma warning restore 612, 618
        }
    }
}