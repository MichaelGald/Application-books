using Application_books.Database.Entitties;
using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Libros
{
    public class LibroCreateDto
    {
        //Data Annotations
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre del libro es requerido.")]
        public string Titulo { get; set; }

        [Display(Name = "Descripcion")]
        [MinLength(10, ErrorMessage = "La {0} debe tener al menos {1} caracteres.")]
        public string Descripcion { get; set; }

        [Display(Name = "Genero")]
        [MinLength(4, ErrorMessage = "El {0} debe tener al menos {1} caracteres.")]
        public string Genero { get; set; }

        [Display(Name = "URL de la img")]
        [Url(ErrorMessage = "La URL de la img no es valida.")]
        public string UrlImg { get; set; }

        [Display(Name = "URL del PDF")]
        [Url(ErrorMessage = "La URL del PDF no es valida.")]
        public string UrlPdf { get; set; }

        [Display(Name = "ID del Autor")]
        public Guid IdAutor { get; set; }

    }
}
