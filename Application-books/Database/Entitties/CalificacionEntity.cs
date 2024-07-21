using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    public class CalificacionEntity 
    {
        public Guid IdCalificacion { get; set; }
        
        public Guid IdLibro { get; set; }
        [ForeignKey(nameof(IdLibro))]
        public virtual LibroEntity Libro { get; set; }

        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        public virtual UsuarioEntity Usuario { get; set; }

        public string Calificacion { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }

    }
}
