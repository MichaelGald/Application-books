namespace Application_books.Dtos.ListaFavoritos
{
    public class ListaFavoritoDto
    {
        public Guid IdListaFavorito { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdLibro { get; set; }
    }
}
