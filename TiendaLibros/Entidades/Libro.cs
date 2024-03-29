﻿using System;
using System.Collections.Generic;

namespace TiendaLibro.Entidades;

public partial class Libro
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public int? GeneroId { get; set; }

    public string ISBN { get; internal set; }
    public virtual List<LibroDetalle> LibroDetalles { get; } = new List<LibroDetalle>();
 
}
