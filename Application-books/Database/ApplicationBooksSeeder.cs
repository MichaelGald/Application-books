using Application_books.Database.Entitties;
using Application_books.Dtos.Usuarios;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace Application_books.Database
{
    public class ApplicationBooksSeeder
    {
        public static async Task LoadDataAsync(
            ApplicationbooksContext context,
            ILoggerFactory loggerFactory
            )
        {
            try
            {
                await LoadAutorAsync(loggerFactory, context);
                await LoadLibrosAsync(loggerFactory, context);                
                await LoadUsuariosAsync(loggerFactory, context);                
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ApplicationBooksSeeder>();
                logger.LogError(e, "Error inicializando la data del API");
            }
        }
        public static async Task LoadUsuariosAsync(ILoggerFactory loggerFactory, ApplicationbooksContext _context)
        {
            try
            {
                var jsonfilePath = "SeedData/usuarios.json";
                var jsonnContent = await File.ReadAllTextAsync(jsonfilePath);
                var usuarios = JsonConvert.DeserializeObject<List<UsuarioEntity>>(jsonnContent);
                if (!await _context.Usuarios.AnyAsync())
                {
                    _context.Usuarios.AddRange(usuarios);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ApplicationbooksContext>();
                logger.LogError(e, "Error al ejecutar el Seed de Usuarios.");
            }
        }

        public static async Task LoadLibrosAsync(ILoggerFactory loggerFactory, ApplicationbooksContext _context)
        {
            try
            {
                var jsonfilePath = "SeedData/libros.json";
                var jsonContent = await File.ReadAllTextAsync(jsonfilePath);
                var libros = JsonConvert.DeserializeObject<List<LibroEntity>>(jsonContent);
                if (!await _context.Libros.AnyAsync())
                {
                    for (int i = 0; i < libros.Count; i++)
                    {
                        libros[i].FechaCreacion = DateTime.Now;
                    }

                    _context.Libros.AddRange(libros);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ApplicationbooksContext>();
                logger.LogError(e, "Error al ejecutar el Seed de libros.");
            }
        }
        public static async Task LoadAutorAsync(ILoggerFactory loggerFactory, ApplicationbooksContext _context)
        {
            try
            {
                var jsonfilePath = "SeedData/autores.json";
                var jsonnContent = await File.ReadAllTextAsync(jsonfilePath);
                var autores = JsonConvert.DeserializeObject<List<AutorEntity>>(jsonnContent);
                if (!await _context.Autores.AnyAsync())
                {
                    _context.Autores.AddRange(autores);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ApplicationbooksContext>();
                logger.LogError(e, "Error al ejecutar el Seed de autores.");
            }
        }
    }
}