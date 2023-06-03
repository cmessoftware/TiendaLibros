using TiendaLibro.Entidades;
using TiendaLibros.UnitOfWorks;

namespace TiendaLibro.Repositorios
{
    public class LibroRepositorio : RepositorioGenerico<Libro>, ILibroRepositorio
    {
        private readonly ILogger<LibroRepositorio> _logger;

        public LibroRepositorio(ILogger<LibroRepositorio> logger,
                                TiendaLibrosContext context) : base(context)
        {
            _logger = logger;
        }


        public async Task<bool> Create(Libro entity)
        {

            return await base.Create(entity);
        }

        public async Task<bool> Update(Libro entity)
        {
            return await base.Update(entity);
        }

        public async Task<List<Libro>> GetAll()
        {
            return await base.GetAll();
        }

        public async Task<Libro> GetById(int? id)
        {
            return await base.GetById(id);
        }
    }
}
