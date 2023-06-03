using TiendaLibro.Mapeos;
using TiendaLibro.Servicios;
using TiendaLibros.UnitOfWorks;

namespace TiendaLibro.Common.Extensiones
{
    public static class ServiceExtensiones
    {
        public static void AddServices(this IServiceCollection services)
        {
            //Configuro inyección de dependencias del UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Configuro inyección de dependencias de los servicios
            services.AddScoped<ILibroServicio, LibroServicio>();
            services.AddScoped<IFormatoServicio, FormatoServicio>();
            services.AddScoped<IGeneroServicio, GeneroServicio>();
            services.AddScoped<ILibroDetalleServicio, LibroDetalleServicio>();

            //Inyección de dependencias de mapeos.
            services.AddScoped<ILibrosMapeo, LibrosMapeo>();
            services.AddScoped<IGeneroMapeo, GeneroMapeo>();
            services.AddScoped<IFormatoMapeo, FormatoMapeo>();
            services.AddScoped<ILibroDetalleMapeo, LibroDetalleMapeo>();
      
        }

        public static string JoinString<T>(this IEnumerable<T> source, string delimiter, Func<T, string> func)
        {
            return String.Join(delimiter, source.Select(func).ToArray());
        }
    }
}
