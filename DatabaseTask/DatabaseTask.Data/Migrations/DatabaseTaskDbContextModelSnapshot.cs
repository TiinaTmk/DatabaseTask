﻿// <auto-generated />
using System;
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    partial class DatabaseTaskDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Core.Domain.Ametinimetused", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ametinimetus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("AmetinimetusedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Ametis_alates")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ametis_kuni")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Osakond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otsese_ülemuse_eesnimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otsese_ülemuse_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otsese_ülemuse_perenimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Otsese_ülemuse_telefon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmetinimetusedId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("Ametinimetuseds");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ametinimetuse_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eesnimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firma_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Harukontor_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Isikukood")
                        .HasColumnType("int");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontakt_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontaktaadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kontakttelefon")
                        .HasColumnType("int");

                    b.Property<string>("Perenimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tööl_alates")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tööl_kuni")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Firma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Koduleht")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontaktisik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kontaktnr")
                        .HasColumnType("int");

                    b.Property<string>("Lühinimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Registrinr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Firmas");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Haiguslehed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Aegunud_haiguspäevi")
                        .HasColumnType("int");

                    b.Property<int>("Allesolevaid_haiguspäevi")
                        .HasColumnType("int");

                    b.Property<DateTime>("Haiguslehe_algus")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Haiguslehe_lõpp")
                        .HasColumnType("datetime2");

                    b.Property<int>("Haiguspäevi_kokku")
                        .HasColumnType("int");

                    b.Property<int>("Kasutatud_haiguspäevi")
                        .HasColumnType("int");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Õigus_haiguslehele")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Haigusleheds");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Harukontor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirmaId")
                        .HasColumnType("int");

                    b.Property<string>("Koduleht")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontaktisik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kontaktnr")
                        .HasColumnType("int");

                    b.Property<string>("Nimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Registrinr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Harukontors");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Laenutus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Laenutamisekp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Laenutatav_kaup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tagastamisekp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Laenutused");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Lapsed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Eesnimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perekonnanimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Sünniaeg")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TöötajaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Vanus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TöötajaId");

                    b.ToTable("Childrens");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Ligipääsuload", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ligipääsu_alguskp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ligipääsu_lõppkp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ligipääsutase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ligipääsuõigus")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Ligipääsuloads");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Puhkused", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Aegunud_puhkusepäevi")
                        .HasColumnType("int");

                    b.Property<int>("Allesolevaid_puhkusepäevi")
                        .HasColumnType("int");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kasutatud_puhkusepäevi")
                        .HasColumnType("int");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Puhkuse_algus")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Puhkuse_lõpp")
                        .HasColumnType("datetime2");

                    b.Property<int>("Puhkuse_päevi_kokku")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Puhkuseds");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Tervisekontroll", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Eelmise_tervisekontrolli_kp")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Tervisekontrolli_vajadus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Uue_tervisekontrolli_kp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("Tervisekontrolls");
                });

            modelBuilder.Entity("EmployeeFirma", b =>
                {
                    b.Property<Guid>("EmployeesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FirmasId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeesId", "FirmasId");

                    b.HasIndex("FirmasId");

                    b.ToTable("EmployeeFirma");
                });

            modelBuilder.Entity("EmployeeHaiguslehed", b =>
                {
                    b.Property<Guid>("EmployeesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HaiguslehedsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeesId", "HaiguslehedsId");

                    b.HasIndex("HaiguslehedsId");

                    b.ToTable("EmployeeHaiguslehed");
                });

            modelBuilder.Entity("EmployeeHarukontor", b =>
                {
                    b.Property<Guid>("EmployeesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HarukontorsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeesId", "HarukontorsId");

                    b.HasIndex("HarukontorsId");

                    b.ToTable("EmployeeHarukontor");
                });

            modelBuilder.Entity("EmployeeLaenutus", b =>
                {
                    b.Property<Guid>("EmployeesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LaenutusedId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeesId", "LaenutusedId");

                    b.HasIndex("LaenutusedId");

                    b.ToTable("EmployeeLaenutus");
                });

            modelBuilder.Entity("FirmaHarukontor", b =>
                {
                    b.Property<Guid>("FirmasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HarukontorsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FirmasId", "HarukontorsId");

                    b.HasIndex("HarukontorsId");

                    b.ToTable("FirmaHarukontor");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Ametinimetused", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Ametinimetused", null)
                        .WithMany("Ametinimetuseds")
                        .HasForeignKey("AmetinimetusedId");

                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employees")
                        .WithMany("Ametinimetuseds")
                        .HasForeignKey("EmployeesId");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Lapsed", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Töötaja")
                        .WithMany("Childrens")
                        .HasForeignKey("TöötajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Töötaja");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Ligipääsuload", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", null)
                        .WithMany("Ligipääsuloads")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Puhkused", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Puhkuseds")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Tervisekontroll", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employees")
                        .WithMany("Tervisekontrolls")
                        .HasForeignKey("EmployeesId");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EmployeeFirma", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Core.Domain.Firma", null)
                        .WithMany()
                        .HasForeignKey("FirmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeHaiguslehed", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Core.Domain.Haiguslehed", null)
                        .WithMany()
                        .HasForeignKey("HaiguslehedsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeHarukontor", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Core.Domain.Harukontor", null)
                        .WithMany()
                        .HasForeignKey("HarukontorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeLaenutus", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Core.Domain.Laenutus", null)
                        .WithMany()
                        .HasForeignKey("LaenutusedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FirmaHarukontor", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Firma", null)
                        .WithMany()
                        .HasForeignKey("FirmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Core.Domain.Harukontor", null)
                        .WithMany()
                        .HasForeignKey("HarukontorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Ametinimetused", b =>
                {
                    b.Navigation("Ametinimetuseds");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.Navigation("Ametinimetuseds");

                    b.Navigation("Childrens");

                    b.Navigation("Ligipääsuloads");

                    b.Navigation("Puhkuseds");

                    b.Navigation("Tervisekontrolls");
                });
#pragma warning restore 612, 618
        }
    }
}
