using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    public class LibroEntity
    {
        [Key]
        [Column("id_libro")]
        public Guid IdLibro {  get; set; }

        [Required]
        [StringLength(50)]
        [Column("titulo")]
        public string Titulo { get; set; }

        [Required]
        [StringLength(200)]
        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(20)]
        [Column("genero")]
        public string Genero { get; set; }

        [StringLength(50)]
        [Column("Fecha de Creación")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required]
        [StringLength(100)]
        [Column("pdf_libro")]
        public string UrlPdf { get; set; }

        [Required]
        [Column("id_autor")]
        public Guid IdAutor {  get; set; }
        [ForeignKey(nameof(IdAutor))]
        public virtual AutorEntity Autor { get; set; }
    }
}
