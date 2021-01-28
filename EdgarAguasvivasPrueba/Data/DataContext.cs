using EdgarAguasvivasPrueba.Models;
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
        public DbSet<Estado> Estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                   .HasMany(d => d.Solicitud)
                    .WithOne(p => p.Persona)
                    .IsRequired();

            modelBuilder.Entity<Solicitud>()
                   .HasOne(d => d.Persona)
                    .WithMany(p => p.Solicitud)                    
                    .IsRequired();

            modelBuilder.Entity<Estado>()
                  .HasMany(d => d.Solicitud)
                   .WithOne(p => p.Estado)
                   .IsRequired();

            modelBuilder.Entity<Solicitud>()
                   .HasOne(d => d.Estado)
                    .WithMany(p => p.Solicitud)
                    .IsRequired();



        }
    }
}
