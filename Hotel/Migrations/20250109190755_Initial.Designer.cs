﻿// <auto-generated />
using System;
using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel.Migrations
{
    [DbContext(typeof(HotelsDBContext))]
    [Migration("20250109190755_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hotel.Models.Newsletter", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Email");

                    b.HasIndex("UserId");

                    b.ToTable("Newsletters");
                });

            modelBuilder.Entity("Hotel.Models.Pracownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "akowalska@hotelxyz.pl",
                            IsAdmin = true,
                            Name = "Anna",
                            Surname = "Kowalska"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jiksinski@hotelxyz.pl",
                            IsAdmin = true,
                            Name = "Jan",
                            Surname = "Iksiński"
                        },
                        new
                        {
                            Id = 3,
                            Email = "pnowak@hotelxyz.pl",
                            IsAdmin = true,
                            Name = "Piotr",
                            Surname = "Nowak"
                        });
                });

            modelBuilder.Entity("Hotel.Models.Rezerwacja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apartment")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Building")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("date");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("HowManyBeds")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("HowManyRooms")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("IDCard")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PostOffice")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("char(6)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("pracownikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("pracownikId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Hotel.Models.Użytkownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("powtorzHaslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "kkowalska@gmail.com",
                            Haslo = "zaq1@WSX",
                            IsAdmin = true,
                            Name = "Katarzyna",
                            Nickname = "123456789",
                            Surname = "Kowalska",
                            powtorzHaslo = "zaq1@WSX"
                        });
                });

            modelBuilder.Entity("Hotel.Models.Newsletter", b =>
                {
                    b.HasOne("Hotel.Models.Użytkownik", "użytkownik")
                        .WithMany("Newsletters")
                        .HasForeignKey("UserId");

                    b.Navigation("użytkownik");
                });

            modelBuilder.Entity("Hotel.Models.Rezerwacja", b =>
                {
                    b.HasOne("Hotel.Models.Użytkownik", "użytkownik")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId");

                    b.HasOne("Hotel.Models.Pracownik", "pracownik")
                        .WithMany("Reservations")
                        .HasForeignKey("pracownikId");

                    b.Navigation("pracownik");

                    b.Navigation("użytkownik");
                });

            modelBuilder.Entity("Hotel.Models.Pracownik", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Hotel.Models.Użytkownik", b =>
                {
                    b.Navigation("Newsletters");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
