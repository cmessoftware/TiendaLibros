using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System;
using System.ComponentModel;
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
            var libro = new Libro();

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
