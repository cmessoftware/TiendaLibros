using TiendaLibro.Entidades;
using TiendaLibros.UnitOfWorks;

namespace TiendaLibro.Repositorios
{
    public class GeneroRepositorio : RepositorioGenerico<Genero>, IGeneroRepositorio
    {
        private readonly ILogger _logger;

        public GeneroRepositorio(ILogger<LibroRepositorio> logger,
                                 TiendaLibrosContext context) : base(context)
        {
            _logger = logger;
        }


        public new async Task<bool> Create(Genero entity)
        {
            return await base.Create(entity);
        }

        public new async Task<bool> Update(Genero entity)
        {
            return await base.Update(entity);
        }

        public new async Task<List<Genero>> GetAll()
        {
            return await base.GetAll();
        }

        public new async Task<Genero> GetById(int? id)
        {
            return await base.GetById(id);
        }
    }
}
