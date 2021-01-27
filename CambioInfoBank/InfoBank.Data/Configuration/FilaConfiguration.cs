using CambioBank.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CambioBank.Data.Configuration
{
    public class FilaConfiguration : IEntityTypeConfiguration<Fila>
    {
        public void Configure(EntityTypeBuilder<Fila> builder)
        {
            builder.HasKey(f => f.Id);
        }
    }
}
