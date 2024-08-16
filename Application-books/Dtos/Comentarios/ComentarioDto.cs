namespace Application_books.Dtos.Comentarios
{
    public class ComentarioDto
    {
        public Guid IdComentario { get; set; }
        public Guid IdLibro { get; set; }
        public Guid IdUsuario { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
