using AutoMapper;

using TiendaLibro.Dto.Request;
using TiendaLibro.Mapeos;
using TiendaLibro.Repositorios;

namespace TiendaLibro.Servicios
{
    public class LibroServicios : ILibroServicios
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ILibroRepositorio _repo;

        public LibroServicios(ILogger<LibroServicios> logger,
                              IMapper mapper,
                              ILibroRepositorio repo)
        {
            _logger = logger;
            _mapper = mapper;
            _repo = repo;
        }


        public async Task<List<LibroDto>> Get()
        {
            

            var libros = await _repo.Get();
            var librosDto = LibrosMapeos.Map ( libros );

            return librosDto;
        }

        public async Task<LibroDto?> GetByIsbn(string isbn)
        {
            var response = await _repo.GetByIsbn(isbn);

            LibroDto libroDto = LibrosMapeos.Map(response);
         
            return libroDto;
        }

        public Task<LibroDto> GetByYear(int date)
        {
            throw new NotImplementedException();
        }

        public async Task<LibroDto> GetLibro(LibroRequestDto libro)
        {
            throw new NotImplementedException();
        }

        public Task<LibroDto> GetLibroByYear(int date)
        {
            throw new NotImplementedException();
        }

        public async Task SaveLibro(LibroDto libro)
        {
            var libroDB = LibrosMapeos.Map(libro);

            await _repo.SaveLibro(libroDB);
        }
    }
}
