using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CambioBank.Domain.Models;
using CambioBank.Data.Configuration;

namespace CambioBank.Data.Context
{
    public class CambioBankContext : DbContext
    {
        public CambioBankContext(DbContextOptions<CambioBankContext> options): base(options)
        {
        }

        public DbSet<Fila> Filas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
