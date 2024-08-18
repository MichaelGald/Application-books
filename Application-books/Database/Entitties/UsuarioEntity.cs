using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    [Table("usuario", Schema = "dbo")]
    public class UsuarioEntity
    {
        [Key]
        [Column("id_usuario")]
        public Guid IdUsuario { get; set; }

        [StringLength(50)]
        [Column("cliente")]
        public string NombreUsuario {  get; set; }

        [StringLength(50)]
        [Column("email")]
        public string Email { get; set; }

        [StringLength(20)]
        [Column("password")]
        public string Password { get; set; }

        public ICollection<MembresiaEntity> Membresia { get; set; } = new List<MembresiaEntity>();
    }
}
