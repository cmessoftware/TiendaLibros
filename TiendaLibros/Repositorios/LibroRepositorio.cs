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
            var libro1 = await (from l in _context.Set<Libro>()
                                join ld in _context.Set<LibroDetalle>()
                                on l.ISBN equals ld.ISBN
                                join ldf in _context.Set<LibroDetalleFormato>()
                                on ld.Id equals ldf.LibroDetalleId
                                join f in _context.Set<Formato>()
                                on ldf.Id equals f.LibroDetalleFormatoId
                                join m in _context.Set<Moneda>()
                                on ldf.Id equals m.LibroDetalleFormatoId
                                where l.ISBN == isbn
                                select l).
                                Include(x => x.LibroDetalles).
                                FirstOrDefaultAsync();

            var formatos = (from ld in libro1.LibroDetalles
                            join ldf in _context.Set<LibroDetalleFormato>()
                            on ld.Id equals ldf.LibroDetalleId
                            join f in _context.Set<Formato>()
                            on ldf.Id equals f.LibroDetalleFormatoId
                            where ld.ISBN == isbn
                            select f).ToList();

            var monedas = (from ld in libro1.LibroDetalles
                           join ldf in _context.Set<LibroDetalleFormato>()
                           on ld.Id equals ldf.LibroDetalleId
                           join m in _context.Set<Moneda>()
                           on ldf.Id equals m.LibroDetalleFormatoId
                           where ld.ISBN == isbn
                           select m).ToList();


            var libroDetalleFormato = (from ld in libro1.LibroDetalles
                                       join ldf in _context.Set<LibroDetalleFormato>()
                                       on ld.Id equals ldf.LibroDetalleId
                                       where ld.ISBN == isbn
                                       select ldf).ToList();

            
            Libro libro = ConstruirLibro(libro1, libroDetalleFormato, formatos, monedas);

            return libro;
        }

        private static Libro ConstruirLibro(Libro? libro1, 
                                            List<LibroDetalleFormato> libroDetallesFormato,
                                            List<Formato> formato,
                                            List<Moneda> monedas)
        {
            var libro = new Libro()
            {
                Autor = libro1.Autor,
                ISBN = libro1.ISBN,
                Titulo = libro1.Titulo,
                GeneroId = libro1.GeneroId,
            };

            var libroDetalles = new List<LibroDetalle>();
           

            foreach (var lds in libro1.LibroDetalles)
            {
                var ld = new LibroDetalle()
                {
                    Editorial = lds.Editorial,
                    Edicion = lds.Edicion,
                    FechaPublicacion = lds.FechaPublicacion,
                    ISBN = lds.ISBN,
                    PortadaLink = lds.PortadaLink,
                    Resumen = lds.Resumen,
                    ResumenLink = lds.ResumenLink,
                };

                foreach (var ldfs in libroDetallesFormato)
                {
                    var ldf = new LibroDetalleFormato()
                    {
                        Precio = ldfs.Precio,
                    };

                    foreach (var fs in ldfs.Formatos)
                    {
                        var f = new Formato()
                        {
                            Nombre = fs.Nombre,
                        };

                        ldf.Formatos.Add(f);
                    }

                    foreach (var mo in ldfs.Monedas)
                    {
                        var m = new Moneda()
                        {
                           Codigo = mo.Codigo,
                           Descripcion = mo.Descripcion,
                           Simbolo = mo.Simbolo
                        };

                        ldf.Monedas.Add(m);
                    }
                    if (ld.LibroDetalleFormatos == null)
                        ld.LibroDetalleFormatos = new List<LibroDetalleFormato>();

                    ld.LibroDetalleFormatos.Add(ldf);
                };

                libroDetalles.Add(ld);
            }

            libro.LibroDetalles.AddRange(libroDetalles);
            

            return libro;
        }

        public Task<List<Libro>> GetLibro(Libro libro)
        {
            throw new NotImplementedException();
        }

        public Task<List<Libro>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
