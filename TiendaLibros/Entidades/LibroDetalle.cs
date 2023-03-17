using TiendaLibro.Dto.Response;

namespace TiendaLibro.Entidades;

public partial class LibroDetalle
{
    public int Id { get; set; }

    public DateTime? FechaPublicacion { get; set; }

    public string Editorial { get; set; } = null!;

    public int Edicion { get; set; }

    public string ISBN { get; set; }

    public List<Formato> Formatos { get; set; }

}
