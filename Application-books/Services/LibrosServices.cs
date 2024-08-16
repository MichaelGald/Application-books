using Application_books.Database;
using Application_books.Database.Entitties;
using Application_books.Dtos.Common;
using Application_books.Dtos.Libros;
using Application_books.Services.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace Application_books.Services
{
    public class LibrosServices : ILibrosServices
    {
        private readonly ApplicationbooksContext _booksContext;
        private readonly IMapper _mapper;

        public LibrosServices(ApplicationbooksContext booksContext, IMapper mapper)
        {
            this._booksContext = booksContext;
            this._mapper = mapper;
        }  
        public async Task<ResponseDto<List<LibroDto>>> GetLibroListAsync()
        {
            var librosEntity = await _booksContext.Libros.ToListAsync();
            var libroDtos = _mapper.Map<List<LibroDto>>(librosEntity);

            return new ResponseDto<List<LibroDto>>
            {
                StatusCode = 200,
                Status = true,
                Message = "Lista de libro obtenida correctamente.",
                Data = libroDtos,
            };
        }
        public async Task<ResponseDto<LibroDto>> GetLibroByAsync(Guid id)
        {
            var librosEntity = await _booksContext.Libros.FirstOrDefaultAsync(c => c.IdLibro == id);
            if (librosEntity == null)
            {
                return new ResponseDto<LibroDto> 
                {
                    StatusCode = 404,
                    Status = false,
                    Message = "No se encontro registro."
                };
            }
            var libroDto = _mapper.Map<LibroDto>(librosEntity);
            return new ResponseDto<LibroDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro obtenido correctamente.",
                Data= libroDto,
            };
        }
        public async Task<ResponseDto<LibroDto>> CreateAsync(LibroCreateDto dto)
        {
            var libroEntity = _mapper.Map<LibroEntity>(dto);
            _booksContext.Libros.Add(libroEntity);
            await _booksContext.SaveChangesAsync();

            var libroDto = _mapper.Map<LibroDto>(libroEntity);

            return new ResponseDto<LibroDto> 
            {
                StatusCode = 201,
                Status = true,
                Message = "Reegistro creado coreectamente.",
                Data = libroDto,
            };
        }
        public async Task<ResponseDto<LibroDto>> EditAsync(LibroEditDto dto, Guid id)
        {
            var libroEntity = await _booksContext.Libros.FirstOrDefaultAsync(e => e.IdLibro == id);
            if (libroEntity is null) 
            {
                return new ResponseDto<LibroDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"El registro registro"
                };
            }
            _mapper.Map<LibroEditDto, LibroEntity>(dto, libroEntity);
            _booksContext.Libros.Update(libroEntity);
            await _booksContext.SaveChangesAsync();

            var libroDto = _mapper.Map<LibroDto>(libroEntity);
            return new ResponseDto<LibroDto>
             {
                    StatusCode = 200,
                    Status = true,
                    Message = "Registro editado correctamente.",
                    Data = libroDto
             };
         }

        public async Task<ResponseDto<LibroDto>> DeleteAsync(Guid id)
        {
            var librosEntity = await _booksContext.Libros.FirstOrDefaultAsync(x => x.IdLibro == id);
            if (librosEntity == null)
            {
                return new ResponseDto<LibroDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"No se encontro el registro"
                };
            }

            _booksContext.Libros.Remove(librosEntity);
            await _booksContext.SaveChangesAsync();
            return new ResponseDto<LibroDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro borrado correctamente"
            };
        }
    }
}
