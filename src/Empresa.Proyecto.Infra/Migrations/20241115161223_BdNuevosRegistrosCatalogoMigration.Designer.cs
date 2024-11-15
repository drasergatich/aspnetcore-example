﻿// <auto-generated />
using System;
using Empresa.Proyecto.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    [DbContext(typeof(MyProjectContext))]
    [Migration("20241115161223_BdNuevosRegistrosCatalogoMigration")]
    partial class BdNuevosRegistrosCatalogoMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.ComplexEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("CatalogExampleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("CatalogExampleId");

                    b.ToTable("ComplexEntity");
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.EntityOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SimpleEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SimpleEntityId");

                    b.ToTable("EntityOption");
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.SimpleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SimpleEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 11, 15, 10, 12, 23, 487, DateTimeKind.Local).AddTicks(309),
                            Modified = new DateTime(2024, 11, 15, 10, 12, 23, 487, DateTimeKind.Local).AddTicks(318),
                            Name = "Nuevo"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Existente"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Reconstruido"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Activo"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Inactivo"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pendiente"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Completado"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cancelado"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "En progreso"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Procesado"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Revisado"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Autorizado"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Denegado"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Suspendido"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Expirado"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Temporal"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Permanente"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Provisional"
                        },
                        new
                        {
                            Id = 19,
                            Created = new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Finalizado"
                        },
                        new
                        {
                            Id = 20,
                            Created = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Reprogramado"
                        },
                        new
                        {
                            Id = 21,
                            Created = new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Duplicado"
                        },
                        new
                        {
                            Id = 22,
                            Created = new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Original"
                        },
                        new
                        {
                            Id = 23,
                            Created = new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Activo temporal"
                        },
                        new
                        {
                            Id = 24,
                            Created = new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Listo para envío"
                        },
                        new
                        {
                            Id = 25,
                            Created = new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "En espera"
                        },
                        new
                        {
                            Id = 26,
                            Created = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nuevo cliente"
                        },
                        new
                        {
                            Id = 27,
                            Created = new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cliente recurrente"
                        },
                        new
                        {
                            Id = 28,
                            Created = new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Producto especial"
                        },
                        new
                        {
                            Id = 29,
                            Created = new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Servicio personalizado"
                        },
                        new
                        {
                            Id = 30,
                            Created = new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "En evaluación"
                        },
                        new
                        {
                            Id = 31,
                            Created = new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aprobado"
                        },
                        new
                        {
                            Id = 32,
                            Created = new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "En corrección"
                        },
                        new
                        {
                            Id = 33,
                            Created = new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Concluido"
                        });
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.ComplexEntity", b =>
                {
                    b.HasOne("Empresa.Proyecto.Core.Entities.SimpleEntity", "CatalogExample")
                        .WithMany()
                        .HasForeignKey("CatalogExampleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogExample");
                });

            modelBuilder.Entity("Empresa.Proyecto.Core.Entities.EntityOption", b =>
                {
                    b.HasOne("Empresa.Proyecto.Core.Entities.SimpleEntity", "Opcion")
                        .WithMany()
                        .HasForeignKey("SimpleEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Opcion");
                });
#pragma warning restore 612, 618
        }
    }
}
