using AutoMapper;
using TiendaLibro.Dto.Response;
using TiendaLibro.Entidades;

namespace TiendaLibro.Mapeos.Resolvers
{
    internal class LibroDetallesResolver : IValueResolver<Libro, List<LibroDetalleDto>, List<LibroDetalleDto>>
    {
        List<LibroDetalleDto> IValueResolver<Libro, List<LibroDetalleDto>, List<LibroDetalleDto>>.Resolve(Libro source, List<LibroDetalleDto> destination, List<LibroDetalleDto> destMember, ResolutionContext context)
        {
            foreach (var s in source.LibroDetalles)
            {
                var ld = new LibroDetalleDto()
                {
                    Edicion = s.Edicion,
                    Editorial = s.Editorial,
                    FechaPublicacion = s.FechaPublicacion,
                };

                foreach (var f in ld.Formatos)
                {
                    var formato = new Formato()
                    {
                        Nombre = f.Nombre,
                    };

                    ld.Formatos.Add(f);
                }

                foreach (var m in ld.Monedas)
                {
                    var moneda = new Moneda()
                    {
                       Codigo = m.Codigo,
                       Descripcion = m.Descripcion,
                       Simbolo = m.Simbolo,
                    };

                    ld.Monedas.Add(m);
                }

                destination.Add(ld);
            }
                       

            return destination;
        }

    }
}