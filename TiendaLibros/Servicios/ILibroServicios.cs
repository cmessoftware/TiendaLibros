using TiendaLibro.Dto.Request;

namespace TiendaLibro.Servicios
{
    public interface ILibroServicios
    {
        public Task<List<LibroDto>> Get();

        public Task<LibroDto> GetByIsbn(string isbn);
        public Task<List<LibroDto>> GetByYear(int date);
        public Task<LibroDto> GetLibro(LibroRequestDto libro);
        public Task<LibroDto> GetLibroByYear ( int date );
    }
}