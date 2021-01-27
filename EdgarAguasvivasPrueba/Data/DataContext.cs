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


        
    }
}
