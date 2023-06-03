using TiendaLibro.Entidades;
using TiendaLibros.UnitOfWorks;

namespace TiendaLibro.Repositorios
{
    public class FormatoRepositorio : RepositorioGenerico<Formato>, IFormatoRepositorio
    {
        private readonly ILogger _logger;

        public FormatoRepositorio(ILogger<FormatoRepositorio> logger,
                                  TiendaLibrosContext context) : base(context)
        {
            _logger = logger;
        }


        public new async Task<bool> Create(Formato entity)
        {
            return await base.Create(entity);
        }

        public new async Task<bool> Update(Formato entity)
        {
            return await base.Update(entity);
        }

        public new async Task<List<Formato>> GetAll()
        {
            return await base.GetAll();
        }

        public new async Task<Formato> GetById(int? id)
        {
            return await base.GetById(id);
        }
    }

}
