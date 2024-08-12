using Application_books.Database.Entitties;
using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Libros
{
    public class LibroDto
    {
        public Guid Idlibro { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Genero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UrlImg {  get; set; }
        public string UrlPdf { get; set; }
        public Guid IdAutor { get; set; }
    }
}
