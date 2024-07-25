using Application_books.Database.Entitties;
using Microsoft.EntityFrameworkCore;


namespace Application_books.Database
{
    public class Application_booksContext : DbContext
    {
            public Application_booksContext(DbContextOptions<Application_booksContext> options)
                : base(options)
            {
            }

            public DbSet<AutorEntity> Autores { get; set; }
            public DbSet<CalificacionEntity> Calificaciones { get; set; }
            public DbSet<LibroEntity> Libros { get; set; }
            public DbSet<ListaFavoritoEntity> ListaFavoritos { get; set; }
            public DbSet<MembresiaEntity> Membresias { get; set; }
            public DbSet<UsuarioEntity> Usuarios { get; set; }

    }
}
