using TiendaLibro.Dto.Request;
using TiendaLibro.Dto.Response;
using TiendaLibro.Entidades;

namespace TiendaLibro.Mapeos
{
    internal class LibrosMapeos
    {
        internal static List<LibroDto> Map ( List<Libro> libros )
        {
            List<LibroDto> librosDto = new List<LibroDto> ();
            foreach (Libro item in libros)
            {
                List<LibroDetalle> auxlb = new List<LibroDetalle> ();
                LibroDto aux = new LibroDto ()
                {
                    Autor = item.Autor,
                    Genero =item.GeneroId.ToString(),
                    Titulo=item.Titulo
                };
                foreach (var librodetalle in item.LibroDetalles)
                {
                    LibroDetalleDto lbdetdto = new LibroDetalleDto ()
                    {
                        Edicion = librodetalle.Edicion,
                        Editorial = librodetalle.Editorial,
                        FechaPublicacion = librodetalle.FechaPublicacion,
                        ISBN = librodetalle.ISBN
                       
                    };
                    aux.LibroDetalles.Add(lbdetdto);

                }
                librosDto.Add ( aux );
            }
            return librosDto;
        }

        internal static LibroDto Map(Libro response)
        {
            throw new NotImplementedException();
        }
    }
}