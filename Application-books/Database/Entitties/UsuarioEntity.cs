namespace Application_books.Database.Entitties
{
    public class UsuarioEntity
    {
        public Guid IdUsuario { get; set; }
        public string NombreUsuario {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
