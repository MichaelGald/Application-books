using Application_books.Database.Entitties;
using Application_books.Dtos.Common;
using Application_books.Dtos.Libros;
using Application_books.Services.Interface;
using Newtonsoft.Json;

namespace Application_books.Services
{
    public class LibrosServices : ILibrosServices
    {
        public readonly string _JSON_FILE;
        public LibrosServices()
        {
            _JSON_FILE = "seedData/libros.json";
        }  
        public async Task<ResponseDto<List<LibroDto>>> GetLibroListAsync()
        {
            return new ResponseDto<List<LibroDto>>
            {
                StatusCode = 200,
                Status = true,
                Message = "Lista de re obtenida correctamente.",
                Data = await ReadLibroFormFileAsync()
            };
        }
        public async Task<ResponseDto<LibroDto>> GetLibroByAsync(Guid id)
        {
            var libros = await ReadLibroFormFileAsync();
            LibroDto libro = libros.FirstOrDefault(c => c.Idlibro == id);
            return new ResponseDto<LibroDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro obtenido correctamente.",
                Data = libro
            };
        }
        public async Task<ResponseDto<LibroDto>> CreateAsync(LibroCreateDto dto)
        {
            var libroDtos = await ReadLibroFormFileAsync();

            var libroDto = new LibroDto
            {
                Idlibro = Guid.NewGuid(),
                Titulo = dto.Titulo,
                Descripcion = dto.Descripcion,
                Genero = dto.Genero,
                FechaCreacion = DateTime.Now,
                UrlPdf = dto.UrlPdf,
                IdAutor = dto.IdAutor,
                Autor = dto.Autor,
            };

            libroDtos.Add(libroDto);
            var libros = libroDtos.Select(x => new LibroEntity 
            {
                IdLibro = x.Idlibro,
                Titulo = x.Titulo,
                Descripcion = x.Descripcion,
                Genero = x.Genero,
                FechaCreacion = DateTime.Now,
                UrlPdf = x.UrlPdf,
                IdAutor = x.IdAutor,
                Autor = x.Autor,
            }).ToList();

            await WriteLibrosToFileAsync(libros);
            return new ResponseDto<LibroDto> 
            {
                StatusCode = 201,
                Status = true,
                Message = "Reegistro creado coreectamente.",
            };
        }
        public async Task<ResponseDto<LibroDto>> EditAsync(LibroEditDto dto, Guid id)
        {
            var libroDto = await ReadLibroFormFileAsync();
            var existingLibro = libroDto.FirstOrDefault(libro => libro.Idlibro == id);
            if (existingLibro is null) 
            {
                return new ResponseDto<LibroDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"El registro {id} no fue encontrado"
                };
            }

            for (int i = 0; i < libroDto.Count; i++)
            {
                if (libroDto[i].Idlibro == id)
                {
                    libroDto[i].Titulo = dto.Titulo;
                    libroDto[i].Descripcion = dto.Descripcion;
                    libroDto[i].Genero = dto.Genero;
                    libroDto[i].UrlPdf = dto.UrlPdf;
                    libroDto[i].IdAutor = dto.IdAutor;
                }
            }

                var libros = libroDto.Select(x => new LibroEntity
                {
                    IdLibro = x.Idlibro,
                    Titulo = x.Titulo,
                    Descripcion = x.Descripcion,
                    Genero = x.Genero,
                    UrlPdf = x.UrlPdf,
                    IdAutor = x.IdAutor,
                }).ToList();

                await WriteLibrosToFileAsync(libros);
                return new ResponseDto<LibroDto>
                {
                    StatusCode = 200,
                    Status = true,
                    Message = "Registro editado correctamente."
                };
            
        }
        public async Task<ResponseDto<LibroDto>> DeleteAsync(Guid id)
        {
            var librosDto = await ReadLibroFormFileAsync();
            var librosToDelete = librosDto.FirstOrDefault(x => x.Idlibro == id);
            if (librosToDelete is null)
            {
                return new ResponseDto<LibroDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"El registro {id} no fue encontrado"
                };
            }

            librosDto.Remove(librosToDelete);
            var libros = librosDto.Select(x => new LibroEntity
            {
               IdLibro = x.Idlibro,
               Titulo = x.Titulo,
               Descripcion = x.Descripcion,
               Genero = x.Genero,
               FechaCreacion = x.FechaCreacion,
               UrlPdf = x.UrlPdf,
               IdAutor = x.IdAutor,

            }).ToList();

            await WriteLibrosToFileAsync(libros);
            return new ResponseDto<LibroDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro borrado correctamente"
            };
        }
        private async Task<List<LibroDto>> ReadLibroFormFileAsync()
        {
            if (!File.Exists(_JSON_FILE))
            {
                return new List<LibroDto>();
            }
            var json = await File.ReadAllTextAsync(_JSON_FILE); 
            var libros = JsonConvert.DeserializeObject<List<LibroEntity>>(json);
            var dtos = libros.Select(x => new LibroDto
            {
                Idlibro = x.IdLibro,
                Titulo = x.Titulo,
                Descripcion = x.Descripcion,
                Genero = x.Genero,
                FechaCreacion = x.FechaCreacion,
                UrlPdf = x.UrlPdf,
                IdAutor = x.IdAutor,
                Autor = x.Autor,
            }).ToList();
            return dtos;
        }
        private async Task WriteLibrosToFileAsync(List<LibroEntity> libros) 
        {
            var json = JsonConvert.SerializeObject(libros, Formatting.Indented);
            if (File.Exists(_JSON_FILE))
            {
                await File.WriteAllTextAsync(_JSON_FILE, json);
            }
        }
    }
}
