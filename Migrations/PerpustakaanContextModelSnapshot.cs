﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Perpustakaan.Data;

namespace Perpustakaan.Migrations
{
    [DbContext(typeof(PerpustakaanContext))]
    partial class PerpustakaanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("anggota_id")
                        .HasColumnType("int");

                    b.Property<int>("buku_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("tanggal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("tanggal_pengembalian")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("tt_pinjam");
                });
#pragma warning restore 612, 618
        }
    }
}
