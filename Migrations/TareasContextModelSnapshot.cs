﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projectoef;

#nullable disable

namespace projectef.Migrations
{
    [DbContext(typeof(TareasContext))]
    partial class TareasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("projectoef.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaId = new Guid("155a6ffb-bb0c-4956-abb1-4e817000e529"),
                            Nombre = "Actividades pendientes",
                            Peso = 20
                        },
                        new
                        {
                            CategoriaId = new Guid("155a6ffb-bb0c-4956-abb1-4e817000e530"),
                            Nombre = "Actividades personales",
                            Peso = 50
                        },
                        new
                        {
                            CategoriaId = new Guid("155a6ffb-bb0c-4956-abb1-4e817000e531"),
                            Nombre = "Actividades laborales",
                            Peso = 30
                        });
                });

            modelBuilder.Entity("projectoef.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TareaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("155a6ffb-bb0c-4956-abb1-4e817000e531"),
                            CategoriaId = new Guid("155a6ffb-bb0c-4956-abb1-4e817000e529"),
                            FechaCreacion = new DateTime(2024, 4, 18, 20, 42, 49, 6, DateTimeKind.Local).AddTicks(5741),
                            PrioridadTarea = 1,
                            Titulo = "Pago de servicios publicos"
                        },
                        new
                        {
                            TareaId = new Guid("155a6ffb-bb0c-4956-abb1-4e817000e532"),
                            CategoriaId = new Guid("155a6ffb-bb0c-4956-abb1-4e817000e530"),
                            FechaCreacion = new DateTime(2024, 4, 18, 20, 42, 49, 6, DateTimeKind.Local).AddTicks(5757),
                            PrioridadTarea = 0,
                            Titulo = "Terminar de ver pelicula en netfix"
                        },
                        new
                        {
                            TareaId = new Guid("155a6ffb-bb0c-4956-abb1-4e817000e533"),
                            CategoriaId = new Guid("155a6ffb-bb0c-4956-abb1-4e817000e531"),
                            FechaCreacion = new DateTime(2024, 4, 18, 20, 42, 49, 6, DateTimeKind.Local).AddTicks(5759),
                            PrioridadTarea = 2,
                            Titulo = "Terminar el reporte mensual de ventas"
                        });
                });

            modelBuilder.Entity("projectoef.Models.Tarea", b =>
                {
                    b.HasOne("projectoef.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("projectoef.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
