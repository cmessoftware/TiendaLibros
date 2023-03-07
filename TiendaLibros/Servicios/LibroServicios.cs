using AutoMapper;

using System.Runtime.CompilerServices;

using TiendaLibro.Dto.Request;
using TiendaLibro.Entidades;
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
            Libro response = await _repo.GetByIsbn(isbn);

            LibroDto libroDto = LibrosMapeos.Map(response);
         
            return libroDto;
        }

        public async Task<List<LibroDto>> GetByYear(int date)
        {
            var response = await _repo.GetByDate ( date );

            List<LibroDto> librosDto = LibrosMapeos.Map ( response );

            return librosDto;
        }

        public async Task<LibroDto> GetLibroByYear ( int date )
        {
            Libro response = await _repo.GetLibroByDate ( date );

            LibroDto libroDto = LibrosMapeos.Map ( response );

            return libroDto;
        }

        public async Task<LibroDto> GetLibro(LibroRequestDto libro)
        {
            return null;
        }

        
    }
}
