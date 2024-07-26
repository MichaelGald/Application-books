using Application_books.Database.Entitties;
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
                await LoadLibrosAsync(loggerFactory, context);
                await LoadAutorAsync(loggerFactory, context);
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ApplicationBooksSeeder>();
                logger.LogError(e, "Error inicializando la data del API");
            }
        }
        // Todo: seed de usuraios
        public static async Task LoadLibrosAsync(ILoggerFactory loggerFactory, ApplicationbooksContext _context)
        {
            try
            {
                var jsonfilePath = "SeedData/libros.json";
                var jsonnContent = await File.ReadAllTextAsync(jsonfilePath);
                var libros = JsonConvert.DeserializeObject<List<LibroEntity>>(jsonnContent);
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
                logger.LogError(e, "Error al ejecutar el Seed de Categoria.");
            }
        }
        public static async Task LoadAutorAsync(ILoggerFactory loggerFactory, ApplicationbooksContext _context)
        {
            try
            {
                var jsonfilePath = "SeedData/autores.json";
                var jsonnContent = await File.ReadAllTextAsync(jsonfilePath);
                var autor = JsonConvert.DeserializeObject<List<AutorEntity>>(jsonnContent);
                if (!await _context.Autores.AnyAsync())
                {
                    _context.Autores.AddRange(autor);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ApplicationbooksContext>();
                logger.LogError(e, "Error al ejecutar el Seed de Categoria.");
            }
        }
    }
}