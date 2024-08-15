using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Application_books.Database.Entitties
{
    public class ComentarioEntity
    {
        [Key]
        [Column("id_comentario")]
        public Guid IdComentario { get; set; }

        [Column("id_libro")]
        public Guid IdLibro { get; set; }
        [ForeignKey(nameof(IdLibro))]
        public virtual LibroEntity Libro { get; set; }

        [Column("id_usuario")]
        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        public virtual UsuarioEntity Usuario { get; set; }

        [StringLength(200)]
        [Column("comentario")]
        public string Comentario { get; set; }

        [Column("fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
