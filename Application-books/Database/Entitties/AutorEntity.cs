using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    public class AutorEntity
    {
        [Column("id_autor")]
        public Guid IdAutor { get; set; }

        [StringLength(50)]
        [Column("autor")]
        public string NombreAutor { get; set; }

        [StringLength(300)]
        [Column("bibliografia")]
        public string Bibliografia { get; set; }
    }
}
