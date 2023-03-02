using System;
using System.Collections.Generic;

namespace TiendaLibro.Entidades;

public partial class LibroDetalleFormato
{
    public int Id { get; set; }

    public decimal Precio { get; set; }

    public int LibroDetalleId { get; set; }

    public virtual ICollection<Formato> Formatos { get; } = new List<Formato>();

    public virtual ICollection<Moneda> Monedas { get; } = new List<Moneda>();
}
