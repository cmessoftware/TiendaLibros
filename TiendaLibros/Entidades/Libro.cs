namespace TiendaLibro.Entidades;

public partial class Libro
{

    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string Resumen { get; set; }

    public string? ResumenLink { get; set; }

    public string PortadaLink { get; set; }

    public int? GeneroId { get; set; }
        
    //Propiedad ee navegación.
    public Genero Genero { get; set; }
    public virtual List<LibroDetalle> LibroDetalles { get; set; }
      
}

