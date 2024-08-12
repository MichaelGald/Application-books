using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Membresia
{
    public class MembresiaEditDto
    {
        [Display(Name = "ActivacionMembresia")]
        public bool ActivaMembresia { get; set; }
    }
}
