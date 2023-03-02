using System;
using System.Collections.Generic;

namespace TiendaLibro.Entidades;

public partial class LibroDetalle
{
    public int Id { get; set; }

    public string ISBN { get; set; } = null!;

    public DateTime? FechaPublicacion { get; set; }

    public string Editorial { get; set; } = null!;

    public string? Resumen { get; set; }

    public string? ResumenLink { get; set; }

    public int? Edicion { get; set; }

    public string? PortadaLink { get; set; }

    public int? LibroId { get; set; }

    public virtual Libro? Libro { get; set; }

    public List<LibroDetalleFormato>? LibroDetalleFormatos { get; set; }
}
