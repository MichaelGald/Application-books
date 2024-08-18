using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    [Table("autor", Schema = "dbo")]
    public class AutorEntity
    {
        [Key]
        [Column("id_autor")]
        public Guid IdAutor { get; set; }

        [Required]
        [StringLength(50)]
        [Column("autor")]
        public string NombreAutor { get; set; }

        [StringLength(1000)]
        [Column("bibliografia")]
        public string Bibliografia { get; set; }

        [Required]
        [StringLength(500)]
        [Column("img_autor")]
        public string UrlImg { get; set; }

        public ICollection<LibroEntity> Libros { get; set; } = new List<LibroEntity>();
    }
}
