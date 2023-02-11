﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestFlower01.Server.Data;

#nullable disable

namespace TestFlower01.Server.Migrations
{
    [DbContext(typeof(AddDbContext))]
    [Migration("20230211071330_SetDb02")]
    partial class SetDb02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TestFlower01.Shared.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TestFlower01.Shared.Entities.Flower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cloure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Flowers");
                });

            modelBuilder.Entity("TestFlower01.Shared.Entities.Oder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("FlowerId")
                        .HasColumnType("int");

                    b.Property<int?>("FlowersId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FlowerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TestFlower01.Shared.Entities.Oder", b =>
                {
                    b.HasOne("TestFlower01.Shared.Entities.Customer", "Customer")
                        .WithMany("Oders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("TestFlower01.Shared.Entities.Flower", "Flower")
                        .WithMany("Oders")
                        .HasForeignKey("FlowerId");

                    b.Navigation("Customer");

                    b.Navigation("Flower");
                });

            modelBuilder.Entity("TestFlower01.Shared.Entities.Customer", b =>
                {
                    b.Navigation("Oders");
                });

            modelBuilder.Entity("TestFlower01.Shared.Entities.Flower", b =>
                {
                    b.Navigation("Oders");
                });
#pragma warning restore 612, 618
        }
    }
}
