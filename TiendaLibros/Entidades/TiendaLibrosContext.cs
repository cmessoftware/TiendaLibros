using Microsoft.EntityFrameworkCore;

namespace TiendaLibro.Entidades;

public partial class TiendaLibrosContext : DbContext
{
    public TiendaLibrosContext()
    {
    }

    public TiendaLibrosContext(DbContextOptions<TiendaLibrosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Formato> Formatos { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<LibroDetalle> LibroDetalles { get; set; }



}