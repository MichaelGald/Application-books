using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    [Table("membresia", Schema = "dbo")]
    public class MembresiaEntity 
    {
        [Key]
        [Column("id_membresia")]
        public Guid IdMembresia { get; set; }

        [Column("id_usuario")]
        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdMembresia))]
        public virtual UsuarioEntity Usuario { get; set; }

        [StringLength(50)]
        [Column("tipo_columna")]
        public string TipoMembresia { get; set; }

        [StringLength(50)]
        [Column("fecha_inicio")]
        public DateTime FechaInicio { get; set; } = DateTime.Now;

        [StringLength(50)]
        [Column("fecha_fin")]
        public DateTime FechaFin { get; set; } = DateTime.Now;
    }
}
