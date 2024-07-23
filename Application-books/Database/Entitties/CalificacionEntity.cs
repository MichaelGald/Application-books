using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    public class CalificacionEntity 
    {
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

        [StringLength(5)]
        [Column("calificacion")]
        public string Calificacion { get; set; }

        [StringLength(200)]
        [Column("comentario")]
        public string Comentario { get; set; }

        [StringLength(30)]
        [Column("fecha")]
        public DateTime Fecha { get; set; }

    }
}
