using System;
using System.Collections.Generic;

namespace TiendaLibro.Dto.Response;

public class FormatoDto
{
     public string Nombre { get; set; } = null!;

    public decimal Precio
    {
        set => decimal.Round(value, 2);
        get => Precio;
    }

}
