﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationTest.Data;

namespace WebApplicationTest.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200127123258_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplicationTest.Models.Alert", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ID");

                    b.ToTable("tbl_alert");
                });

            modelBuilder.Entity("WebApplicationTest.Models.ssids", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("auth")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("channel")
                        .HasColumnType("double");

                    b.Property<string>("cipher")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("enc")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("mac")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("pwr")
                        .HasColumnType("int");

                    b.Property<string>("ssid")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ID");

                    b.ToTable("ssids");
                });

            modelBuilder.Entity("WebApplicationTest.Models.user", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("user_id");

                    b.ToTable("tbl_login");
                });

            modelBuilder.Entity("WebApplicationTest.Models.whitelist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("auth")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("channel")
                        .HasColumnType("double");

                    b.Property<string>("cipher")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("enc")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("mac")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("pwr")
                        .HasColumnType("int");

                    b.Property<string>("ssid")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ssid_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("whitelist");
                });
#pragma warning restore 612, 618
        }
    }
}
