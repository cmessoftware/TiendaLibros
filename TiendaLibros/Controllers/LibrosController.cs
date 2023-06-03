using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TiendaLibro.Dto;
using TiendaLibro.Servicios;

namespace TiendaLibro.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LibrosController : Controller
    {
        private readonly ILibroServicio _servicio;
        private readonly IMapper _mapper;

        public LibrosController(ILibroServicio servicio,
                                IMapper mapper)
        {
            _servicio = servicio;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("/")]
        public async Task<JsonResult> GetAll()
        {
            try
            {
                var libro = await _servicio.GetAll();

                var libroDto = _mapper.Map<LibroDto>(libro);

                return Json(
                        new
                        {
                            titulo = libroDto.Titulo,
                            autor = libroDto.Autor,
                            isbn = libroDto.ISBN,
                            estado = HttpStatusCode.OK
                        }
                    );
            }
            catch (Exception ex)
            {
                return Json(
                        new
                        {
                            errors = new { ex.Message },
                            estado = HttpStatusCode.InternalServerError
                        }
                    );
            }
        }

        [HttpGet]
        [Route("{id?}")]
        public async Task<JsonResult> GetById(int? id)
        {
            try
            {
                var libro = await _servicio.GetAll();

                var libroDto = _mapper.Map<LibroDto>(libro);

                return Json(
                        new
                        {
                            titulo = libroDto.Titulo,
                            autor = libroDto.Autor,
                            isbn = libroDto.ISBN,
                            estado = HttpStatusCode.OK
                        }
                    );
            }
            catch (Exception ex)
            {
                return Json(
                        new
                        {
                            errors = new { ex.Message },
                            estado = HttpStatusCode.InternalServerError
                        }
                    );
            }
        }

    }
}
