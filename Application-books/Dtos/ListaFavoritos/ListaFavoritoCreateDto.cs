using Application_books.Database.Entitties;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.ListaFavoritos
{
    public class ListaFavoritoCreateDto
    {
        [Display(Name = "IdUsuario")]
        [Required(ErrorMessage = "El ID del usuario es requerido.")]
        public Guid IdUsuario { get; set; }

        [Display(Name = "IdLibro")]
        [Required(ErrorMessage = "El ID del Liubro es requerido.")]
        public Guid IdLibro { get; set; }
    }
}
