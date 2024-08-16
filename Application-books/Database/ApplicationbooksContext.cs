using Application_books.Database.Entitties;
using Microsoft.EntityFrameworkCore;


namespace Application_books.Database
{
    public class ApplicationbooksContext : DbContext
    {
            public ApplicationbooksContext(DbContextOptions options)
                : base(options)
            {
            }

            public DbSet<AutorEntity> Autores { get; set; }
            public DbSet<CalificacionEntity> Calificaciones { get; set; }
            public DbSet<LibroEntity> Libros { get; set; }
            public DbSet<ListaFavoritoEntity> ListaFavoritos { get; set; }
            public DbSet<MembresiaEntity> Membresias { get; set; }
            public DbSet<UsuarioEntity> Usuarios { get; set; }

            public DbSet<ComentarioEntity> Comentarios { get; set; }

    }
}
