using System;
using System.Collections.Generic;

namespace TiendaLibro.Dto.Response;

public class LibroDetalleDto
{
    
    public DateTime? FechaPublicacion { get; set; }

    public string Editorial { get; set; } = null!;
  
    public int Edicion { get; set; }

    public string ISBN { get; set; }

    public List<FormatoDto> Formatos { get; set; }
}
