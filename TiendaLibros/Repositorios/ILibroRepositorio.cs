using TiendaLibro.Entidades;

namespace TiendaLibro.Repositorios
{
    public interface ILibroRepositorio
    {
        public Task<List<Libro>> Get();
        public Task<List<Libro>> GetByDate ( int date );
        public Task<Libro> GetByIsbn(string isbn);

        public Task<List<Libro>> GetLibro(Libro libro);
        public Task<Libro> GetLibroByDate ( int date );
    }
}