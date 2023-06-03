using TiendaLibro.Entidades;
using TiendaLibros.UnitOfWorks;

namespace TiendaLibro.Servicios
{
    public class GeneroServicio : IGeneroServicio
    {
        private readonly ILogger<GeneroServicio> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public GeneroServicio(ILogger<GeneroServicio> logger,
                               IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Genero entity)
        {
            return await _unitOfWork.Genero.Create(entity);
        }

        public async Task<bool> Delete(int? id)
        {
            return await _unitOfWork.Genero.Delete(id);
        }

        public async Task<List<Genero>> GetAll()
        {
            return await _unitOfWork.Genero.GetAll();
        }

        public async Task<Genero> GetById(int? id)
        {
            return await _unitOfWork.Genero.GetById(id);
        }

        public async Task<bool> Update(Genero entity)
        {
            return await _unitOfWork.Genero.Update(entity);
        }
    }
}
