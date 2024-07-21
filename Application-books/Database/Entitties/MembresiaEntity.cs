using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    public class MembresiaEntity 
    {
        public Guid IdMembresia { get; set; }

        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdMembresia))]
        public virtual UsuarioEntity Usuario { get; set; }

        public string TipoMembresia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
