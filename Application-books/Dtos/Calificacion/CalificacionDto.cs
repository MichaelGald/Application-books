using Application_books.Database.Entitties;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Calificacion
{
    public class CalificacionDto
    {
        public Guid IdCalificacion { get; set; }
        public Guid IdLibro { get; set; }
        public Guid IdUsuario { get; set; }
        public int Puntuacion { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
