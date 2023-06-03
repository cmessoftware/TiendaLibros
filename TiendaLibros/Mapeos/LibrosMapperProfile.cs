
using AutoMapper;
using TiendaLibro.Dto;
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
        }
    }
}
