using TiendaLibro.Entidades;
using TiendaLibros.UnitOfWorks;

namespace TiendaLibro.Servicios
{
    public class LibroDetalleServicio : ILibroDetalleServicio
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;

        public LibroDetalleServicio(ILogger<LibroDetalleServicio> logger,
                                    IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(LibroDetalle entity)
        {
            return await _unitOfWork.LibroDetalle.Create(entity);
        }

        public async Task<bool> Delete(int? id)
        {
            return await _unitOfWork.LibroDetalle.Delete(id);
        }

        public async Task<List<LibroDetalle>> GetAll()
        {
            return await _unitOfWork.LibroDetalle.GetAll();
        }

        public async Task<LibroDetalle> GetById(int? id)
        {
            return await _unitOfWork.LibroDetalle.GetById(id);
        }

        public async Task<bool> Update(LibroDetalle entity)
        {
            return await _unitOfWork.LibroDetalle.Update(entity);
        }
    }

}
