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
        [ForeignKey(nameof(IdUsuario))]
        public virtual UsuarioEntity Usuario { get; set; }

        [Column("activa_membresia")]
        public bool ActivaMembresia { get; set; }

        [Column("fecha_inicio")]
        public DateTime FechaInicio { get; set; } = DateTime.Now;

        [Column("fecha_fin")]
        public DateTime? FechaFin { get; set; }

        [Column("fecha_cancelacion")]
        public DateTime? FechaCancelacion { get; set; }
    }
}
