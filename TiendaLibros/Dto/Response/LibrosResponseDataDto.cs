namespace TiendaLibro.Dto.Response
{
    public class LibrosResponseDataDto
    {
        public string Genero { get; set; }

        public string? Resumen { get; set; }

        public string? ResumenLink { get; set; }

        public string? PortadaLink { get; set; }

        public List<LibroDetalleDto> Detalles { get; set; }
    }
}
