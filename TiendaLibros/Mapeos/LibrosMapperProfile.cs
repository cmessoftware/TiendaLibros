
using AutoMapper;
using TiendaLibro.Dto.Request;
using TiendaLibro.Dto.Response;
using TiendaLibro.Entidades;

namespace TiendaLibro.Mapeos
{
    public class LibrosMapperProfile : Profile
    {
        public LibrosMapperProfile()
        {
            CreateMap<LibroDto, Libro>();
            CreateMap<GeneroDto, Genero>();
            CreateMap<LibroDetalleDto, LibroDetalle>();
            CreateMap<FormatoDto, Formato>();
            CreateMap<MonedaDto, Moneda>();
        }
    }
}
