using TiendaLibro.Dto.Response;

namespace TiendaLibro.Entidades;

public partial class Formato
{
    public int Id { get; set; }

    public string Nombre { get; set; }
    public string CodigoMoneda { get; set; }

    public decimal Precio { get; set; }

    public int LibroDetalleId { get; set; }

    public LibroDetalle LibroDetalle { get; set; }

    public List<Moneda> Moneda { get; set; }
}
