using TiendaLibro.Entidades;
using TiendaLibro.Repositorios;

namespace TiendaLibros.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TiendaLibrosContext _context;
        private readonly ILibroRepositorio libro;
        private readonly IGeneroRepositorio genero;
        private readonly IFormatoRepositorio formato;
        private readonly ILibroDetalleRepositorio libroDetalle;

        public UnitOfWork(TiendaLibrosContext context,
                          ILibroRepositorio libro,
                          IGeneroRepositorio genero,
                          IFormatoRepositorio formato,
                          ILibroDetalleRepositorio libroDetalle
                         )
        {
            _context = context;
            Libro = libro;
            Genero = genero;
            Formato = formato;
            LibroDetalle = libroDetalle;
        }

        public ILibroRepositorio Libro { get; }
        public IGeneroRepositorio Genero { get; }
        public IFormatoRepositorio Formato { get; }
        public ILibroDetalleRepositorio LibroDetalle { get; }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

    }
}