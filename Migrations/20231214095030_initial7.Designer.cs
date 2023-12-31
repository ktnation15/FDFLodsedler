﻿// <auto-generated />
using System;
using FDFLodsedler.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FDFLodsedler.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231214095030_initial7")]
    partial class initial7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FDFLodsedler.Model.Bestyrelse", b =>
                {
                    b.Property<int>("Bestyrelse_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Bestyrelse_Id"));

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bestyrelse_Id");

                    b.ToTable("Bestyrelses");
                });

            modelBuilder.Entity("FDFLodsedler.Model.Betaling", b =>
                {
                    b.Property<int>("Betal_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Betal_Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Betal_Id");

                    b.ToTable("Betalings");
                });

            modelBuilder.Entity("FDFLodsedler.Model.Børn", b =>
                {
                    b.Property<int>("Børn_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Børn_Id"));

                    b.Property<int?>("GruppeId")
                        .HasColumnType("int")
                        .HasColumnName("Gruppe_Id");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Børn_Id");

                    b.ToTable("Børns");
                });

            modelBuilder.Entity("FDFLodsedler.Model.BørneGruppe", b =>
                {
                    b.Property<int>("Gruppe_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gruppe_Id"));

                    b.Property<int?>("LederId")
                        .HasColumnType("int")
                        .HasColumnName("Leder_Id");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Gruppe_Id");

                    b.ToTable("BørnGruppes");
                });

            modelBuilder.Entity("FDFLodsedler.Model.Leder", b =>
                {
                    b.Property<int>("Leder_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Leder_Id"));

                    b.Property<string>("BrugerId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Leder_Id");

                    b.ToTable("Leders");
                });

            modelBuilder.Entity("FDFLodsedler.Model.Lodseldler", b =>
                {
                    b.Property<int>("Lod_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Lod_Id"));

                    b.Property<int>("AntalUdleveret")
                        .HasColumnType("int");

                    b.Property<int?>("BørneId")
                        .HasColumnType("int")
                        .HasColumnName("Børn_Id");

                    b.HasKey("Lod_Id");

                    b.ToTable("Lodsedlers");
                });

            modelBuilder.Entity("FDFLodsedler.Model.Salg", b =>
                {
                    b.Property<int>("Salg_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Salg_Id"));

                    b.Property<int>("AntalReturneret")
                        .HasColumnType("int");

                    b.Property<int>("AntalSolgt")
                        .HasColumnType("int");

                    b.Property<int?>("BørneId")
                        .HasColumnType("int")
                        .HasColumnName("Børn_Id");

                    b.HasKey("Salg_Id");

                    b.ToTable("Salgs");
                });
#pragma warning restore 612, 618
        }
    }
}
