namespace TiendaLibro.Entidades;

public class LibroDetalle
{
    public int Id { get; set; }

    public string Resumen { get; set; }

    public string? ResumenLink { get; set; }

    public string PortadaLink { get; set; }
    public DateTime? FechaPublicacion { get; set; }

    public string Editorial { get; set; } = null!;

    public int Edicion { get; set; }

    public List<Formato> Formatos { get; set; }

}
