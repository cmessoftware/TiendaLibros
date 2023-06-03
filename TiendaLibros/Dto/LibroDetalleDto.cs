namespace TiendaLibro.Dto;

public class LibroDetalleDto
{

    public DateTime? FechaPublicacion { get; set; }

    public string Editorial { get; set; } = null!;

    public int Edicion { get; set; }

    public string Resumen { get; set; }

    public string ResumenLink { get; set; }

    public string PortadaLink { get; set; }

    public List<FormatoDto> Formatos { get; set; }
}
