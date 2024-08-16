using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Autor
{
    public class AutorDto
    {
        public Guid IdAutor { get; set; }
        public string NombreAutor { get; set; }
        public string Bibliografia { get; set; }
    }
}
