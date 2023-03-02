using AutoMapper;
using TiendaLibro.Dto.Request;
using TiendaLibro.Dto.Response;
using TiendaLibro.Mapeos.Resolvers;
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
            List<LibroDto> libroDtos = null;

            //var libro = await _repo.Get();

            return libroDtos;
        }

        public async Task<LibroDto?> GetByIsbn(string isbn)
        {
            var response = await _repo.GetByIsbn(isbn);

            var libro = _mapper.Map<LibroDto>(response);

            //libro = LibroMapper.CompletarLibroDetalleMap(libro);

         
            return libro;
        }

        public Task<LibroDto> GetByYear(int date)
        {
            throw new NotImplementedException();
        }

        public async Task<LibroDto> GetLibro(LibroRequestDto libro)
        {
            throw new NotImplementedException();
        }

    }
}
