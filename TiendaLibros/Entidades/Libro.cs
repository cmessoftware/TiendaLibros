namespace TiendaLibro.Entidades;

public partial class Libro
{

    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string ISBN { get; set; }


    //Propiedad de navegación.
    public List<Genero> Generos { get; set; }
    public LibroDetalle LibroDetalle { get; set; }

}

