using Application_books.Database.Entitties;
using Newtonsoft.Json;
using System.Data.Entity;

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
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ApplicationBooksSeeder>();
                logger.LogError(e, "Error inicializando la data del API");
            }
        }
        // Todo: seed de usuraios
        public static async Task LoadLibrosAsync(ILoggerFactory loggerFactory, ApplicationbooksContext context)
        {
            try
            {
                var jsonfilePath = "SeedData/libros.json";
                var jsonnContent = await File.ReadAllTextAsync(jsonfilePath);
                var libros = JsonConvert.DeserializeObject<List<LibroEntity>>(jsonnContent);
                if (!await context.Libros.AnyAsync())
                {
                    for (int i = 0; i < libros.Count; i++)
                    {
                        libros[i].FechaCreacion = DateTime.Now;
                    }
                    context.AddRange(libros);
                    await context.SaveChangesAsync();
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