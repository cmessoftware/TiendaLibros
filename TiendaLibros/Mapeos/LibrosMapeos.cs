using Microsoft.AspNetCore.Components.Forms;
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

          
            return librosDto;
        }

        internal static LibroDto Map(Libro response)
        {
            LibroDto libro = new LibroDto();


            return libro;
        }

        internal static Libro Map(LibroDto lib)
        {
            var libro = new Libro()
            { 
            Autor = lib.Autor,
            Genero = new Genero()
            { 
                Nombre = lib.Genero.Nombre
            
            }

            };

            return libro;
        }
    }
}