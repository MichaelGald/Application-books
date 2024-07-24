using Application_books.Dtos.Common;
using Application_books.Dtos.Libros;
using Application_books.Services.Interface;

namespace Application_books.Services
{
    public class LibrosServices : ILibrosServices
    {
        public readonly string _JSON_FILE;
        public LibrosServices()
        {
            _JSON_FILE = "seedData/categories.json";
        }
        public Task<ResponseDto<LibroDto>> CreateAsync(LibroCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<LibroDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<LibroDto>> EditAsync(LibroEditDto dto, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<LibroDto>> GetLibroByAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<LibroDto>>> GetLibroListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
