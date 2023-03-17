using System;
using System.Collections.Generic;

namespace TiendaLibro.Dto.Response;

public class FormatoDto
{
    public string Nombre { get; set; } = null!;

    public string CodigoMoneda { get; set; }

    public decimal Precio { get; set; }

    public List<MonedaDto> Moneda { get; set; }

}
