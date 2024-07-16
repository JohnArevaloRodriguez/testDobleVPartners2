﻿// <auto-generated />
using System;
using BEDobleVPartners.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BEDobleVPartners.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BEDobleVPartners.Models.Credencial", b =>
                {
                    b.Property<int>("idCredencial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCredencial"), 1L, 1);

                    b.Property<DateTime?>("FechaCreacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCredencial");

                    b.ToTable("Credenciales");
                });

            modelBuilder.Entity("BEDobleVPartners.Models.Identificacion", b =>
                {
                    b.Property<int>("idIdentificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idIdentificacion"), 1L, 1);

                    b.Property<string>("TipoIdentificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idIdentificacion");

                    b.ToTable("Identificacion");
                });

            modelBuilder.Entity("BEDobleVPartners.Models.Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPersona"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DocumentoIdentidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaCreacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NumeroIdentificacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idCredencial")
                        .HasColumnType("int");

                    b.Property<int>("idIdentificacion")
                        .HasColumnType("int");

                    b.HasKey("IdPersona");

                    b.HasIndex("idCredencial");

                    b.HasIndex("idIdentificacion");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("BEDobleVPartners.Models.Persona", b =>
                {
                    b.HasOne("BEDobleVPartners.Models.Credencial", "Credencial")
                        .WithMany()
                        .HasForeignKey("idCredencial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BEDobleVPartners.Models.Identificacion", "Identificacion")
                        .WithMany()
                        .HasForeignKey("idIdentificacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Credencial");

                    b.Navigation("Identificacion");
                });
#pragma warning restore 612, 618
        }
    }
}
