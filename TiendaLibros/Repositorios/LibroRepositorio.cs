using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System;
using System.ComponentModel;
using System.Security.Cryptography;
using TiendaLibro.Entidades;

namespace TiendaLibro.Repositorios
{
    public class LibroRepositorio : ILibroRepositorio
    {
        private readonly ILogger _logger;   
        private readonly IMapper _mapper;
        private readonly TiendaLibrosContext _context;

        public LibroRepositorio(ILogger<LibroRepositorio> logger,
                                IMapper mapper,
                                TiendaLibrosContext context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
        }

        public async Task<Libro?> GetByIsbn(string isbn)
        {
            var libro = await (from l in _context.Set<Libro>()
                               join ld in _context.Set<LibroDetalle>()
                               on l.Id equals ld.LibroId
                               join ldf in _context.Set<LibroDetalleFormato>()
                               on ld.Id equals ldf.LibroDetalleId
                               join f in _context.Set<Formato>()
                               on ldf.Id equals f.LibroDetalleFormatoId
                               join m in _context.Set<Moneda>()
                               on ldf.Id equals m.LibroDetalleFormatoId
                               where ld.ISBN == isbn
                               select l)
                               .Include(x => x.LibroDetalles)
                               .FirstOrDefaultAsync();
                        
            return libro;
        }

   
        public Task<List<Libro>> GetLibro(Libro libro)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Libro>> Get()
        {
            var libros = await _context.Libros.ToListAsync();
            return libros;
        }
    }
}
