using TiendaLibro.Dto.Response;

namespace TiendaLibro.Dto.Request;

public partial class LibroDto
{
  
    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string Resumen { get; set; }

    public string ResumenLink { get; set; }

    public GeneroDto Genero { get; set; }

    public string PortadaLink { get; set; }

    public List<LibroDetalleDto> LibroDetalles { get; set; } = new List<LibroDetalleDto>();

}
