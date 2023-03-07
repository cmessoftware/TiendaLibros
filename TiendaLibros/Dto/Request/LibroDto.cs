using TiendaLibro.Dto.Response;
using TiendaLibro.Entidades;

namespace TiendaLibro.Dto.Request;

public partial class LibroDto
{
    public string ISBN { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string Genero { get; set; }

    public List<LibroDetalleDto> LibroDetalles { get; set; } = new List<LibroDetalleDto>();

}
