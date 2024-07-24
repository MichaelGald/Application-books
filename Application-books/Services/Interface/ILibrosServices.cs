using Application_books.Dtos.Common;
using Application_books.Dtos.Libros;
using Azure;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;

namespace Application_books.Services.Interface
{
    public interface ILibrosServices
    {
        Task<ResponseDto<List<LibroDto>>> GetLibroListAsync();
        Task<ResponseDto<LibroDto>> GetLibroByAsync(Guid id);
        Task<ResponseDto<LibroDto>> CreateAsync(LibroCreateDto dto);
        Task<ResponseDto<LibroDto>> EditAsync(LibroEditDto dto, Guid id);
        Task<ResponseDto<LibroDto>> DeleteAsync(Guid id);
    }
}
