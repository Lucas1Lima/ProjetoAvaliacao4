﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(WebApplication1Context))]
    [Migration("20211027143647_la")]
    partial class la
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Pages.Entrada.Entradas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("HoraEntrada")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeEntrada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorEntrada")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("WebApplication1.Pages.Saida.Saidas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("HoraSaida")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeSaida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorSaida")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Saidas");
                });

            modelBuilder.Entity("WebApplication1.Pages.Verificar.Verificar", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorEntrada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorSaida")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Verificar");
                });

            modelBuilder.Entity("WebApplication1.Pages.Verificar.Verificar", b =>
                {
                    b.HasOne("WebApplication1.Pages.Entrada.Entradas", "Entrada")
                        .WithMany()
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Pages.Saida.Saidas", "Saidas")
                        .WithMany()
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrada");

                    b.Navigation("Saidas");
                });
#pragma warning restore 612, 618
        }
    }
}
