using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_books.Database.Entitties
{
    [Table("lista_favorito", Schema = "dbo")]
    public class ListaFavoritoEntity
    {
        [Key]
        [Column("id_listafavorito")]
        public Guid IdListaFavorito { get; set; }

        [Column("id_usuario")]
        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        public virtual UsuarioEntity Usuario { get; set; }


        [Column("id_libro")]
        public Guid IdLibro { get; set; }
        [ForeignKey(nameof(IdLibro))]
        public virtual LibroEntity Libro { get; set; }
    }
}
