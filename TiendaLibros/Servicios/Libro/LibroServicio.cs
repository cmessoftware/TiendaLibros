using TiendaLibro.Entidades;
using TiendaLibros.UnitOfWorks;

namespace TiendaLibro.Servicios
{
    public class LibroServicio : ILibroServicio
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;

        public LibroServicio(ILogger<LibroServicio> logger,
                             IUnitOfWork unitOfWork
                             )
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Libro entity)
        {
            return await _unitOfWork.Libro.Create(entity);
        }

        public async Task<bool> Delete(int? id)
        {
            return await _unitOfWork.Libro.Delete(id);
        }

        public async Task<List<Libro>> GetAll()
        {
            return await _unitOfWork.Libro.GetAll();
        }

        public async Task<Libro> GetById(int? id)
        {
            return await _unitOfWork.Libro.GetById(id);
        }

        public async Task<bool> Update(Libro entity)
        {
            return await _unitOfWork.Libro.Update(entity);
        }
    }
}
