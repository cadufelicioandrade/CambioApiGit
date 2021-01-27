﻿// <auto-generated />
using System;
using CambioBank.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CambioBank.Data.Migrations
{
    [DbContext(typeof(CambioBankContext))]
    partial class InfoBankContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CambioBank.Domain.Models.Cotacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Cotacao");
                });

            modelBuilder.Entity("CambioBank.Domain.Models.Fila", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<bool>("EstaNaFila");

                    b.Property<string>("Moeda");

                    b.HasKey("Id");

                    b.ToTable("Filas");
                });
#pragma warning restore 612, 618
        }
    }
}
