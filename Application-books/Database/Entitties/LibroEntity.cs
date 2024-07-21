using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    public class LibroEntity 
    {
        public Guid IdLibro {  get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Genero { get; set; }
        public DateTime FechaSubida { get; set; }
        public string UrlPdf { get; set; }

        public Guid IdAutor {  get; set; }
        [ForeignKey(nameof(IdAutor))]
        public virtual AutorEntity Autor { get; set; }
    }
}
