using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TiendaLibros.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Display(Name = "Libro Title")]
        [Required]
        public string Titulo { get; set; }

        public string Genero { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 10000)]
        public decimal Precio { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }
    }
}
