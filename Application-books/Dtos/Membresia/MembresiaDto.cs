using Application_books.Database.Entitties;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Membresia
{
    public class MembresiaDto
    {
        public Guid IdMembresia { get; set; }
        public Guid IdUsuario { get; set; }
        public bool ActivaMembresia { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime? FechaFin { get; set; } 
        public DateTime? FechaCancelacion { get; set; } 
    }
}
