﻿// <auto-generated />
using System;
using CustomerRegistry.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerRegistry.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240619225500_AjusteCodigo")]
    partial class AjusteCodigo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CustomerRegistry.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastPaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("NextPaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("varchar(17)");

                    b.Property<string>("Plan")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("PlanPrice")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("SubscriPlan")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "antonio@gmail.com",
                            IsActive = true,
                            LastPaymentDate = new DateTime(2024, 6, 19, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(3844),
                            Name = "Antônio",
                            NextPaymentDate = new DateTime(2024, 7, 19, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(3844),
                            PhoneNumber = "(22)5666-7856",
                            Plan = "Monthly",
                            PlanPrice = 30m,
                            SubscriPlan = 1
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "beatriz@yahoo.com",
                            IsActive = false,
                            LastPaymentDate = new DateTime(2024, 5, 19, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(4182),
                            Name = "Beatriz",
                            NextPaymentDate = new DateTime(2024, 5, 19, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(4182),
                            PhoneNumber = "(11)9455-1234",
                            Plan = "Annual",
                            PlanPrice = 120m,
                            SubscriPlan = 12
                        },
                        new
                        {
                            CustomerId = 3,
                            Email = "carlos@outlook.com",
                            IsActive = true,
                            LastPaymentDate = new DateTime(2024, 6, 9, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(4197),
                            Name = "Carlos",
                            NextPaymentDate = new DateTime(2025, 6, 9, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(4197),
                            PhoneNumber = "(21)9876-5432",
                            Plan = "Annual",
                            PlanPrice = 35m,
                            SubscriPlan = 12
                        },
                        new
                        {
                            CustomerId = 4,
                            Email = "daniela@gmail.com",
                            IsActive = true,
                            LastPaymentDate = new DateTime(2024, 4, 19, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(4233),
                            Name = "Daniela",
                            NextPaymentDate = new DateTime(2024, 5, 19, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(4233),
                            PhoneNumber = "(31)9988-7766",
                            Plan = "Monthly",
                            PlanPrice = 25m,
                            SubscriPlan = 1
                        },
                        new
                        {
                            CustomerId = 5,
                            Email = "eduardo@gmail.com",
                            IsActive = false,
                            LastPaymentDate = new DateTime(2024, 3, 19, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(4240),
                            Name = "Eduardo",
                            NextPaymentDate = new DateTime(2024, 3, 19, 19, 55, 0, 272, DateTimeKind.Local).AddTicks(4240),
                            PhoneNumber = "(41)9234-5678",
                            Plan = "Annual",
                            PlanPrice = 150m,
                            SubscriPlan = 12
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
