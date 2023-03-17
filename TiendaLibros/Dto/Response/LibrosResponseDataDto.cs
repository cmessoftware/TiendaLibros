using TiendaLibro.Dto.Request;

namespace TiendaLibro.Dto.Response
{
    public class LibrosResponseDataDto
    {
        public LibroDto Libro { get; set; }

        public List<LibroDetalleDto> LibroDetalles { get; set; }
    }
}
