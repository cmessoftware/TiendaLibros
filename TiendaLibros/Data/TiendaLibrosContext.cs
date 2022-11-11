using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TiendaLibros.Models;

namespace TiendaLibros.Data
{
    public class TiendaLibrosContext : DbContext
    {
        public TiendaLibrosContext (DbContextOptions<TiendaLibrosContext> options)
            : base(options)
        {
        }

        public DbSet<Libro> Libro { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>().HasData(new Libro
            {
                Id = 1,
                Titulo = "Libro1",
                Genero = "Genero1",
                Precio = 2400,
                FechaPublicacion = new DateTime(2012, 4, 23)
            }, new Libro
            {
                Id = 2,
                Titulo = "Libro2",
                Genero = "Genero2",
                Precio = 3000,
                FechaPublicacion = new DateTime(2008, 6, 13)
            }, new Libro
            {
                Id = 3,
                Titulo = "Libro3",
                Genero = "Genero3",
                Precio = 3000,
                FechaPublicacion = new DateTime(2008, 6, 13)
            }, new Libro
            {
                Id = 4,
                Titulo = "Libro4",
                Genero = "Genero4",
                Precio = 3000,
                FechaPublicacion = new DateTime(2008, 6, 13)
            }, new Libro
            {
                Id = 5,
                Titulo = "Libro5",
                Genero = "Genero5",
                Precio = 6000,
                FechaPublicacion = new DateTime(2008, 6, 13)
            }, new Libro
            {
                Id = 6,
                Titulo = "Libro6",
                Genero = "Genero6",
                Precio = 4000,
                FechaPublicacion = new DateTime(2008, 6, 13)
            }, new Libro
            {
                Id = 7,
                Titulo = "Libro7",
                Genero = "Genero7",
                Precio = 4500,
                FechaPublicacion = new DateTime(2008, 6, 13)
            }, new Libro
            {
                Id = 8,
                Titulo = "Libro8",
                Genero = "Genero8",
                Precio = 4500,
                FechaPublicacion = new DateTime(2008, 6, 13)
            }, new Libro
            {
                Id = 9,
                Titulo = "Libro9",
                Genero = "Genero9",
                Precio = 6600,
                FechaPublicacion = new DateTime(2008, 6, 13)
            }, new Libro
            {
                Id = 10,
                Titulo = "Libro10",
                Genero = "Genero10",
                Precio = 7000,
                FechaPublicacion = new DateTime(2008, 6, 13)
            });
        }

    }
}
