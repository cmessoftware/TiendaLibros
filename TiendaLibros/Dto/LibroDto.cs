namespace TiendaLibro.Dto;

public partial class LibroDto
{

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;
    public string ISBN { get; set; }

    public List<GeneroDto> Generos { get; set; }
    public LibroDetalleDto LibroDetalle { get; set; }

}
