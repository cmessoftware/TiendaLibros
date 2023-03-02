using AutoMapper;
using System.Data.SqlTypes;
using TiendaLibro.Dto.Request;
using TiendaLibro.Dto.Response;
using TiendaLibro.Entidades;
using TiendaLibro.Mapeos.Resolvers;

namespace TiendaLibro.Mapeos
{
    public class LibroProfile : Profile
    {
        public LibroProfile()
        {
            CreateMap<Libro, LibroDto>()
                .ForMember(dst => dst.Titulo, src => src.MapFrom(s => s.Titulo))
                .ForMember(dst => dst.Autor, src => src.MapFrom(s => s.Autor))
                .ForMember(dst => dst.Genero, src => src.MapFrom(s => s.GeneroId));
      
        
        }
    }
}
