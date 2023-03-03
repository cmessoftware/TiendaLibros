using TiendaLibro.Entidades;

namespace TiendaLibro.Repositorios
{
    public interface ILibroRepositorio
    {
        public Task<List<Libro>> Get();

        public Task<Libro> GetByIsbn(string isbn);

        public Task<List<Libro>> GetLibro(Libro libro);
    }
}