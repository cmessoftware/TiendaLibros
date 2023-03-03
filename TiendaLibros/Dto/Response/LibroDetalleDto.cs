using System;
using System.Collections.Generic;

namespace TiendaLibro.Dto.Response;

public  class LibroDetalleDto
{
    
    public DateTime? FechaPublicacion { get; set; }

    public string Editorial { get; set; } = null!;

  
    public int? Edicion { get; set; }

    public string ISBN { get; set; }
    public virtual List<FormatoDto> Formatos { get; } = new List<FormatoDto>();

    public virtual List<MonedaDto> Monedas { get; } = new List<MonedaDto>();
}
