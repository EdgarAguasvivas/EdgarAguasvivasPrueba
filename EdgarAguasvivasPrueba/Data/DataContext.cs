﻿using EdgarAguasvivasPrueba.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdgarAguasvivasPrueba.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
      
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.Property(e => e.Persona)
                    .IsRequired();

                entity.Property(e => e.FechaCreacion)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Estado)
                    .IsRequired();

                entity.Property(e => e.PersonaId)
               


            });

            modelBuilder.Entity<Persona>(entity =>
            {

                entity.Property(e => e.Nombre)
                    .IsRequired();

                entity.Property(e => e.Apellido)
                  .IsRequired();

                entity.Property(e => e.Sexo)
                    .IsRequired();


            });
        }


    }
}
