using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Calificacion
{
    public class CalificacionCreateDto
    {
        [Display(Name = "IdLibro")]
        [Required(ErrorMessage = "El Id es requerido.")]
        public Guid IdLibro { get; set; }
        [Display(Name = "IdUsuario")]
        [Required(ErrorMessage = "El Id es requerido.")]
        public Guid IdUsuario { get; set; }
        [Display(Name = "Puntuacion")]
        [Required(ErrorMessage = "El valor de estrellas es requerido.")]
        public int Puntuacion { get; set; }
        [Display(Name = "Comentario")]
        [Required(ErrorMessage = "El comentario es requrido.")]
        public string Comentario { get; set; }
    }
}
