﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_ef_core_6.DataContext;

#nullable disable

namespace dotnet_ef_core_6.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230110153452_AddKosToDataBase")]
    partial class AddKosToDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("dotnet_ef_core_6.DataContext.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_code");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("dotnet_ef_core_6.DataContext.CustomerEntity", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("customer_address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("customer_city");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("customer_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("customer_gender");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("customer_province");

                    b.HasKey("CustomerId");

                    b.ToTable("tbl_customer");
                });

            modelBuilder.Entity("dotnet_ef_core_6.DataContext.KosEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("kos_id");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("kos_gender");

                    b.Property<string>("JenisKos")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("kos_jenis");

                    b.Property<int>("LamaSewa")
                        .HasColumnType("int")
                        .HasColumnName("kos_waktu");

                    b.Property<string>("NamaPenyewa")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("kos_nama");

                    b.Property<int>("Sewa")
                        .HasColumnType("int")
                        .HasColumnName("kos_sewa");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("kos_status");

                    b.HasKey("Id");

                    b.ToTable("tbl_kos");
                });

            modelBuilder.Entity("dotnet_ef_core_6.DataContext.RentalEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("HariSewa")
                        .HasColumnType("int")
                        .HasColumnName("rental_harisewa");

                    b.Property<string>("Jenis")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("rental_jenis");

                    b.Property<string>("Merk")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("rental_merk");

                    b.Property<string>("NamaPenyewa")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("rental_nama");

                    b.Property<int>("Sewa")
                        .HasColumnType("int")
                        .HasColumnName("rental_sewa");

                    b.HasKey("Id");

                    b.ToTable("tbl_rental");
                });

            modelBuilder.Entity("dotnet_ef_core_6.DataContext.ShipperEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Branch")
                        .HasColumnType("int")
                        .HasColumnName("shipper_branch");

                    b.Property<string>("NamaShipper")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("shipper_name");

                    b.Property<int>("PriceShipper")
                        .HasColumnType("int")
                        .HasColumnName("shipper_price");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("shipper_product");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("shipper_region");

                    b.HasKey("Id");

                    b.ToTable("tbl_shipper");
                });
#pragma warning restore 612, 618
        }
    }
}
