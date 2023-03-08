using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TiendaLibro.Entidades;

namespace TiendaLibro.Repositorios
{
    public class LibroRepositorio : ILibroRepositorio
    {
        private readonly ILogger _logger;   
        private readonly IMapper _mapper;
        private readonly TiendaLibrosContext _context;

        public LibroRepositorio(ILogger<LibroRepositorio> logger,
                                IMapper mapper,
                                TiendaLibrosContext context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
        }

        public async Task<Libro>? GetByIsbn(string isbn)
        {

            var libro = await _context.Libros
                               .Include(x => x.LibroDetalles)
                                    .ThenInclude(x => x.LibroDetalleFormatos)
                                        .ThenInclude(x => x.Monedas)
                               .Include(x => x.Genero)
                               .FirstOrDefaultAsync(x => x.ISBN == isbn);

            return libro;
        }

   
        public Task<List<Libro>> GetLibro(Libro libro)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Libro>> Get()
        {
            
            var libros = await _context.Libros
                               .Include(x => x.LibroDetalles)
                                    .ThenInclude(x => x.LibroDetalleFormatos)
                                        .ThenInclude(x => x.Monedas)
                               .Include(x => x.Genero)
                               .ToListAsync();


            return libros;
        }

        public async Task SaveLibro(Libro libroDB)
        {
            //Agrego el cambio. 
            await _context.AddAsync(libroDB);

            //Ejecuto el cambio.
            await _context.SaveChangesAsync();
        }
    }
}
