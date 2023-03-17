using Microsoft.EntityFrameworkCore;

namespace TiendaLibro.Entidades;

public partial class TiendaLibrosContext : DbContext
{
    private readonly IConfiguration _configuration;

    public TiendaLibrosContext(DbContextOptions<TiendaLibrosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Formato> Formatos { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<LibroDetalle> LibroDetalles { get; set; }

    public virtual DbSet<Moneda> Moneda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLlocaldb;Initial Catalog=TiendaLibros-Clase");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Formato>(entity =>
        {
            entity.ToTable("Formato");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodigoMoneda)
                .HasMaxLength(3);
            entity.Property(e => e.Precio)
                .HasPrecision(18, 2);
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LibroDetalleId);
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.ToTable("Genero");

            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.ToTable("Libro");

            entity.Property(e => e.Autor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PortadaLink)
                 .HasMaxLength(256)
                 .IsUnicode(false);
            entity.Property(e => e.Resumen)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ResumenLink)
                .HasMaxLength(256)
                .IsUnicode(false);

        });

        modelBuilder.Entity<LibroDetalle>(entity =>
        {
            entity.ToTable("LibroDetalle");

            entity.Property(e => e.ISBN)
                  .HasMaxLength(16)
                  .IsUnicode(false);
            entity.Property(e => e.Editorial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaPublicacion).HasColumnType("date");
         
        });

        modelBuilder.Entity<Moneda>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Simbolo)
                .HasMaxLength(3)
                .IsUnicode(false);

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
