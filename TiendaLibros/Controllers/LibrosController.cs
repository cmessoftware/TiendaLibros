using Microsoft.AspNetCore.Mvc;
using TiendaLibro.Dto.Request;
using TiendaLibro.Dto.Response;
using TiendaLibro.Servicios;

namespace TiendaLibro.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ILibroServicios _servicio;

        public LibrosController(ILibroServicios servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        [Route("/")]
        public async Task<ActionResult<LibroResponseDto>> Get()
        {
            List<LibroDto> libro = await _servicio.Get();

            return Ok(libro);
        }

        [HttpGet]
        [Route("{isbn}")]
        public async Task<ActionResult<LibroResponseDto>> GetById(string isbn)
        {
            LibroDto libro = await _servicio.GetByIsbn(isbn);

            return Ok(libro);
        }

        [HttpGet]
        [Route("{date:int}")]
        public async Task<ActionResult<LibroResponseDto>> GetByYear(int date)
        {
            LibroDto libro = await _servicio.GetByYear(date);

            return Ok(libro);
        }

        [HttpPost]
        [Route("{consulta}")]
        public async Task<ActionResult<LibroResponseDto>> Get(int date)
        {
            LibroDto libro = await _servicio.GetByYear(date);

            return Ok(libro);
        }
    }
}
