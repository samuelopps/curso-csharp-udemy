﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebApp.Data;
using SalesWebApp.Models;

namespace SalesWebApp.Migrations
{
    [DbContext(typeof(SalesWebAppContext))]
    [Migration("20221028184026_otherEntities")]
    partial class otherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebApp.Models.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departament");
                });

            modelBuilder.Entity("SalesWebApp.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SellerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("SalesWebApp.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DepartamentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<double>("baseSalary");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SalesWebApp.Models.SalesRecord", b =>
                {
                    b.HasOne("SalesWebApp.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("SalesWebApp.Models.Seller", b =>
                {
                    b.HasOne("SalesWebApp.Models.Departament", "Departament")
                        .WithMany("Sallers")
                        .HasForeignKey("DepartamentId");
                });
#pragma warning restore 612, 618
        }
    }
}
