namespace TiendaLibro.Entidades;

public partial class Formato
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? LibroDetalleFormatoId { get; set; }

    public virtual LibroDetalleFormato? LibroDetalleFormato { get; set; }
}
