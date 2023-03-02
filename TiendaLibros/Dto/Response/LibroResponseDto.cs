using TiendaLibro.Dto.Comun;

namespace TiendaLibro.Dto.Response
{
    public class LibroResponseDto
    {

        public List<LibrosResponseDataDto> Libros { get; set; }

        public List<ErrorDto> Errores { get; set; }

    }
}
