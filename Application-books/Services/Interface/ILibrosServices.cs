using Application_books.Dtos.Common;
using Application_books.Dtos.Libros;

namespace Application_books.Services.Interface
{
    public interface ILibrosServices
    {
        Task<ResponseDto<PaginationDto<List<LibroDto>>>> GetLibroListAsync(string searchTerm = "", int page = 1);
        Task<ResponseDto<LibroDto>> GetLibroByAsync(Guid id);
        Task<ResponseDto<LibroDto>> CreateAsync(LibroCreateDto dto);
        Task<ResponseDto<LibroDto>> EditAsync(LibroEditDto dto, Guid id);
        Task<ResponseDto<LibroDto>> DeleteAsync(Guid id);
        Task<ResponseDto<List<LibroDto>>> GetLibroListDestacadosAsync();
    }
}
