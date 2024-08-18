using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Application_books.Dtos.Membresia;

namespace Application_books.Dtos.Usuarios
{
    public class UsuarioDto
    {
        public Guid IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<MembresiaDto> Membresia { get; set; }
    }
}
