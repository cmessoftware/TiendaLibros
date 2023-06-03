using AutoMapper;
using TiendaLibro.Dto;
using TiendaLibro.Entidades;

namespace TiendaLibro.Mapeos
{
    internal class LibrosMapeo : ILibrosMapeo
    {
        private readonly IMapper _mapper;

        public LibrosMapeo(IMapper mapper)
        {
            this._mapper = mapper;
        }
        public List<LibroDto> Map(List<Libro> libros)
        {
            List<LibroDto> librosDto = new List<LibroDto>();


            return librosDto;
        }

        public Libro Map(LibroDto lib)
        {

            var libro = new Libro()
            {
                Autor = lib.Autor,
            };

            foreach (var genDto in lib.Generos)
            {
                var gen = _mapper.Map<Genero>(genDto);
                libro.Generos.Add(gen);
            }

            return libro;
        }
    }
}