using System;
using System.Collections.Generic;

namespace TiendaLibro.Entidades;

public partial class Moneda
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Simbolo { get; set; } = null!;

    public string? Descripcion { get; set; }
 
}
