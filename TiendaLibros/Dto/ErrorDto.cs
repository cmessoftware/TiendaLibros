namespace TiendaLibro.Dto
{
    public class ErrorDto
    {
        public string Codigo { get; set; }
        public string Mensaje { get; set; }

        public string Descripcion { get; set; }

        public SeveridadEnum Severidad { get; set; }
    }
}