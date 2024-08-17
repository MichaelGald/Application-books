using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Application_books.Dtos.Libros;

namespace Application_books.Dtos.Autor
{
    public class AutorDto
    {
        public Guid IdAutor { get; set; }
        public string NombreAutor { get; set; }
        public string Bibliografia { get; set; }
        public string UrlImg { get; set; }
        public List<LibroDto> Libros { get; set; }
    }
}
