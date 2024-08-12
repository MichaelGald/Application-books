using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Membresia
{
    public class MembresiaCreateDto
    {
        [Display(Name = "IdUsuario")]
        [Required(ErrorMessage = "El Id es requerido.")]
        public Guid IdUsuario { get; set; }

        [Display(Name = "ActivacionMembresia")]
        [Required(ErrorMessage = "El activado de membresia es requerido.")]
        public bool ActivaMembresia { get; set; }
    }
}
