using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    [Table("calificacion", Schema = "dbo")]
    public class CalificacionEntity 
    {
        [Key]
        [Column("id_calificacion")]
        public Guid IdCalificacion { get; set; }

        [Column("id_libro")]
        public Guid IdLibro { get; set; }
        [ForeignKey(nameof(IdLibro))]
        public virtual LibroEntity Libro { get; set; }

        [Column("id_usuario")]
        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        public virtual UsuarioEntity Usuario { get; set; }

        [Range(1, 5)]
        [Column("puntuacion")]
        public int Puntuacion { get; set; }

        [StringLength(200)]
        [Column("comentario")]
        public string Comentario { get; set; }

        [StringLength(30)]
        [Column("fecha")]
        public DateTime Fecha { get; set; }
    }
}
