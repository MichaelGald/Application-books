using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    public class ListaFavoritoEntity
    {
        public Guid IdListaFavorito { get; set; }

        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        public virtual UsuarioEntity Usuario { get; set; }

        public Guid IdLibro { get; set; }
        [ForeignKey(nameof(IdLibro))]
        public virtual LibroEntity Libro { get; set; }
    }
}
