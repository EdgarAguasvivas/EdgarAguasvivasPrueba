﻿// <auto-generated />
using System;
using EdgarAguasvivasPrueba.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EdgarAguasvivasPrueba.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210128000532_editdatacontex5")]
    partial class editdatacontex5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EdgarAguasvivasPrueba.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("EdgarAguasvivasPrueba.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pasaporte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("EdgarAguasvivasPrueba.Models.Solicitud", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("EdgarAguasvivasPrueba.Models.Solicitud", b =>
                {
                    b.HasOne("EdgarAguasvivasPrueba.Models.Estado", "Estado")
                        .WithMany("Solicitud")
                        .HasForeignKey("EstadoId");

                    b.HasOne("EdgarAguasvivasPrueba.Models.Persona", "Persona")
                        .WithMany("Solicitud")
                        .HasForeignKey("PersonaId");

                    b.Navigation("Estado");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("EdgarAguasvivasPrueba.Models.Estado", b =>
                {
                    b.Navigation("Solicitud");
                });

            modelBuilder.Entity("EdgarAguasvivasPrueba.Models.Persona", b =>
                {
                    b.Navigation("Solicitud");
                });
#pragma warning restore 612, 618
        }
    }
}
