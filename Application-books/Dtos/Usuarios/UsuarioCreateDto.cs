using System.ComponentModel.DataAnnotations;
namespace Application_books.Dtos.Usuarios
{
    public class UsuarioCreateDto
    {
        [Display(Name = "Nombre")]
        [MinLength(4, ErrorMessage = "El {0} debe tener al menos {1} caracteres.")]
        public string NombreUsuario { get; set; }

        [Display(Name = "Email")]
        [MinLength(4, ErrorMessage = "El {0} debe tener al menos {1} caracteres.")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [MinLength(4, ErrorMessage = "El {0} debe tener al menos {1} caracteres.")]
        public string Password { get; set; }

    }
}
