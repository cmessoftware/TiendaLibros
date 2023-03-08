using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using TiendaLibro.Dto.Request;
using TiendaLibro.Dto.Response;
using TiendaLibro.Entidades;

namespace TiendaLibro.Mapeos
{
    internal class LibrosMapeos
    {
        internal static List<LibroDto> Map (List<Libro> libros )
        {
            List<LibroDto> librosDto = new List<LibroDto> ();

            #region Version 1
            //foreach (Libro item in libros)
            //{
            //    List<LibroDetalle> auxlb = new List<LibroDetalle> ();
            //    LibroDto aux = new LibroDto ()
            //    {
            //        Autor = item.Autor,
            //        Genero =item.GeneroId.ToString(),
            //        Titulo=item.Titulo
            //    };
            //    foreach (var librodetalle in item.LibroDetalles)
            //    {
            //        LibroDetalleDto lbdetdto = new LibroDetalleDto ()
            //        {
            //            Edicion = librodetalle.Edicion,
            //            Editorial = librodetalle.Editorial,
            //            FechaPublicacion = librodetalle.FechaPublicacion,
            //            ISBN = librodetalle.ISBN

            //        };
            //        aux.LibroDetalles.Add(lbdetdto);

            //    }
            //    librosDto.Add ( aux );
            //}
            #endregion

            foreach ( Libro libro in libros )
            {
                var libroDto = Map(libro);
                librosDto.Add(libroDto);
            }

            return librosDto;
        }

        internal static LibroDto Map(Libro response)
        {
            var libro = new LibroDto()
            { 
                Autor = response.Autor,
                Genero = response.Genero?.Nombre,
                ISBN = response.ISBN,
                Titulo = response.Titulo
            };

            foreach (var librodetalle in response.LibroDetalles)
            {
                LibroDetalleDto lbdetdto = new LibroDetalleDto()
                {
                    Edicion = librodetalle.Edicion,
                    Editorial = librodetalle.Editorial,
                    FechaPublicacion = librodetalle.FechaPublicacion,
                    ISBN = librodetalle.ISBN
                };

                
                foreach (var ldf in librodetalle.LibroDetalleFormatos)
                {

                    if (ldf.Formatos != null)
                    {
                        foreach (var fr in ldf.Formatos)
                        {
                            var formato = new FormatoDto()
                            {
                                Nombre = fr.Nombre,
                                Precio = ldf.Precio
                            };

                            lbdetdto.Formatos.Add(formato);
                        };
                    }

                    if (ldf.Monedas != null)
                    {
                        foreach (var mo in ldf.Monedas)
                        {
                            var moneda = new MonedaDto()
                            {
                                Codigo = mo.Codigo,
                                Descripcion = mo.Descripcion,
                                Simbolo = mo.Simbolo
                            };

                            lbdetdto.Monedas.Add(moneda);
                        };
                    }
                }

                libro.LibroDetalles.Add(lbdetdto);

            }
         
            return libro;
        }

        internal static Libro Map(LibroDto libro)
        {
            throw new NotImplementedException();
        }
    }
}