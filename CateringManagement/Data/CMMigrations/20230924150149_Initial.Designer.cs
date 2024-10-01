﻿// <auto-generated />
using System;
using CateringManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CateringManagement.Data.CMMigrations
{
    [DbContext(typeof(CateringContext))]
    [Migration("20230924150149_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("CateringManagement.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CustomerCode")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CateringManagement.Models.Function", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("BaseCharge")
                        .HasColumnType("REAL");

                    b.Property<int>("CustomerID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("Deposit")
                        .HasColumnType("REAL");

                    b.Property<bool>("DepositPaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DurationDays")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FunctionTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GuaranteedNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LobbySign")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<bool>("NoGratuity")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("NoHST")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PerPersonCharge")
                        .HasColumnType("REAL");

                    b.Property<double>("SOCAN")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("FunctionTypeID");

                    b.ToTable("Functions");
                });

            modelBuilder.Entity("CateringManagement.Models.FunctionType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("FunctionTypes");
                });

            modelBuilder.Entity("CateringManagement.Models.Function", b =>
                {
                    b.HasOne("CateringManagement.Models.Customer", "Customer")
                        .WithMany("Functions")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CateringManagement.Models.FunctionType", "FunctionType")
                        .WithMany("Functions")
                        .HasForeignKey("FunctionTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("FunctionType");
                });

            modelBuilder.Entity("CateringManagement.Models.Customer", b =>
                {
                    b.Navigation("Functions");
                });

            modelBuilder.Entity("CateringManagement.Models.FunctionType", b =>
                {
                    b.Navigation("Functions");
                });
#pragma warning restore 612, 618
        }
    }
}
