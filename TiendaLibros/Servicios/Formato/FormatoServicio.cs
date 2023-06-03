using TiendaLibro.Entidades;
using TiendaLibros.UnitOfWorks;

namespace TiendaLibro.Servicios
{
    public class FormatoServicio : IFormatoServicio
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;

        public FormatoServicio(ILogger<FormatoServicio> logger,
                               IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this._unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Formato entity)
        {
            return await _unitOfWork.Formato.Create(entity);
        }

        public async Task<bool> Delete(int? id)
        {
            return await _unitOfWork.Formato.Delete(id);
        }

        public async Task<List<Formato>> GetAll()
        {
            return await _unitOfWork.Formato.GetAll();
        }

        public async Task<Formato> GetById(int? id)
        {
            return await _unitOfWork.Formato.GetById(id);
        }

        public async Task<bool> Update(Formato entity)
        {
            return await _unitOfWork.Formato.Update(entity);
        }
    }
}
