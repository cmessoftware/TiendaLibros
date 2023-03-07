﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaLibro.Entidades;

#nullable disable

namespace TiendaLibro.Migrations
{
    [DbContext(typeof(TiendaLibrosContext))]
    partial class TiendaLibrosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TiendaLibro.Entidades.Formato", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("LibroDetalleFormatoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("LibroDetalleFormatoId");

                    b.ToTable("Formato", (string)null);
                });

            modelBuilder.Entity("TiendaLibro.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Genero", (string)null);
                });

            modelBuilder.Entity("TiendaLibro.Entidades.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Libro", (string)null);
                });

            modelBuilder.Entity("TiendaLibro.Entidades.LibroDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Edicion")
                        .HasColumnType("int");

                    b.Property<string>("Editorial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("FechaPublicacion")
                        .HasColumnType("date");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ISBN");

                    b.Property<int?>("LibroId")
                        .HasColumnType("int");

                    b.Property<string>("PortadaLink")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Resumen")
                        .HasMaxLength(2000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("ResumenLink")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("LibroId");

                    b.ToTable("LibroDetalle", (string)null);
                });

            modelBuilder.Entity("TiendaLibro.Entidades.LibroDetalleFormato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LibroDetalleId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("LibroDetalleId");

                    b.ToTable("LibroDetalleFormato", (string)null);
                });

            modelBuilder.Entity("TiendaLibro.Entidades.Moneda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("LibroDetalleFormatoId")
                        .HasColumnType("int");

                    b.Property<string>("Simbolo")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)");

                    b.HasKey("Id");

                    b.HasIndex("LibroDetalleFormatoId");

                    b.ToTable("Moneda");
                });

            modelBuilder.Entity("TiendaLibro.Entidades.Formato", b =>
                {
                    b.HasOne("TiendaLibro.Entidades.LibroDetalleFormato", "LibroDetalleFormato")
                        .WithMany("Formatos")
                        .HasForeignKey("LibroDetalleFormatoId")
                        .HasConstraintName("FK_Formato_LibroDetalleFormato");

                    b.Navigation("LibroDetalleFormato");
                });

            modelBuilder.Entity("TiendaLibro.Entidades.Libro", b =>
                {
                    b.HasOne("TiendaLibro.Entidades.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("TiendaLibro.Entidades.LibroDetalle", b =>
                {
                    b.HasOne("TiendaLibro.Entidades.Libro", "Libro")
                        .WithMany("LibroDetalles")
                        .HasForeignKey("LibroId")
                        .HasConstraintName("FK_LibroDetalle_Libro");

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("TiendaLibro.Entidades.LibroDetalleFormato", b =>
                {
                    b.HasOne("TiendaLibro.Entidades.LibroDetalle", null)
                        .WithMany("LibroDetalleFormatos")
                        .HasForeignKey("LibroDetalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TiendaLibro.Entidades.Moneda", b =>
                {
                    b.HasOne("TiendaLibro.Entidades.LibroDetalleFormato", "LibroDetalleFormato")
                        .WithMany("Monedas")
                        .HasForeignKey("LibroDetalleFormatoId")
                        .HasConstraintName("FK_Moneda_LibroDetalleFormato");

                    b.Navigation("LibroDetalleFormato");
                });

            modelBuilder.Entity("TiendaLibro.Entidades.Libro", b =>
                {
                    b.Navigation("LibroDetalles");
                });

            modelBuilder.Entity("TiendaLibro.Entidades.LibroDetalle", b =>
                {
                    b.Navigation("LibroDetalleFormatos");
                });

            modelBuilder.Entity("TiendaLibro.Entidades.LibroDetalleFormato", b =>
                {
                    b.Navigation("Formatos");

                    b.Navigation("Monedas");
                });
#pragma warning restore 612, 618
        }
    }
}
