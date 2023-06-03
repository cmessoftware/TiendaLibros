using TiendaLibro.Entidades;
using TiendaLibros.UnitOfWorks;

namespace TiendaLibro.Repositorios
{
    public class LibroDetalleRepositorio : RepositorioGenerico<LibroDetalle>, ILibroDetalleRepositorio
    {
        private readonly ILogger _logger;

        public LibroDetalleRepositorio(ILogger<LibroDetalleRepositorio> logger,
                                       TiendaLibrosContext context) : base(context)
        {
            _logger = logger;
        }

        public new async Task<bool> Create(LibroDetalle entity)
        {
            return await base.Create(entity);
        }

        public new async Task<bool> Update(LibroDetalle entity)
        {
            return await base.Update(entity);
        }

        public new async Task<List<LibroDetalle>> GetAll()
        {
            return await base.GetAll();
        }

        public new async Task<LibroDetalle> GetById(int? id)
        {
            return await base.GetById(id);
        }
    }
}
