using TiendaLibro.Repositorios;

namespace TiendaLibros.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ILibroRepositorio Libro { get; }
        IGeneroRepositorio Genero { get; }
        IFormatoRepositorio Formato { get; }
        ILibroDetalleRepositorio LibroDetalle { get; }

        int SaveChanges();
    }
}