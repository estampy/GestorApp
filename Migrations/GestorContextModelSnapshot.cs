﻿// <auto-generated />
using System;
using GestorApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestorApp.Migrations
{
    [DbContext(typeof(GestorContext))]
    partial class GestorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("GestorApp.Models.Apps", b =>
                {
                    b.Property<int>("AppsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("AppsId");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("GestorApp.Models.Instalaciones", b =>
                {
                    b.Property<int>("InstalacionesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Exitosa")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.HasKey("InstalacionesId");

                    b.ToTable("Instalaciones");
                });

            modelBuilder.Entity("GestorApp.Models.Operarios", b =>
                {
                    b.Property<int>("OperariosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("OperariosId");

                    b.ToTable("Operarios");
                });

            modelBuilder.Entity("GestorApp.Models.Sensores", b =>
                {
                    b.Property<int>("SensoresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("SensoresId");

                    b.ToTable("Sensores");
                });

            modelBuilder.Entity("GestorApp.Models.Telefonos", b =>
                {
                    b.Property<int>("TelefonosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .HasColumnType("text");

                    b.Property<float>("Precio")
                        .HasColumnType("float");

                    b.HasKey("TelefonosId");

                    b.ToTable("Telefonos");
                });

            modelBuilder.Entity("SensoresTelefonos", b =>
                {
                    b.Property<int>("SensoresId")
                        .HasColumnType("int");

                    b.Property<int>("TelefonosId")
                        .HasColumnType("int");

                    b.HasKey("SensoresId", "TelefonosId");

                    b.HasIndex("TelefonosId");

                    b.ToTable("SensoresTelefonos");
                });

            modelBuilder.Entity("SensoresTelefonos", b =>
                {
                    b.HasOne("GestorApp.Models.Sensores", null)
                        .WithMany()
                        .HasForeignKey("SensoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestorApp.Models.Telefonos", null)
                        .WithMany()
                        .HasForeignKey("TelefonosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
