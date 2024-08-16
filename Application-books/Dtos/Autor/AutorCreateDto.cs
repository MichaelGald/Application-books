using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Autor
{
    public class AutorCreateDto
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre del libro es requerido.")]
        public string NombreAutor { get; set; }
        [Display(Name = "Descripcion")]
        [MinLength(10, ErrorMessage = "La {0} debe tener al menos {1} caracteres.")]
        public string Bibliografia { get; set; }
        [Display(Name = "URL de la img")]
        [Url(ErrorMessage = "La URL de la img no es valida.")]
        public string UrlImg { get; set; }
    }
}
