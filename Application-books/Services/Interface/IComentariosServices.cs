using Application_books.Dtos.Comentarios;
using Application_books.Dtos.Common;

namespace Application_books.Services.Interface
{
    public interface IComentariosServices
    {
        Task<ResponseDto<ComentarioDto>> CreateAsync(ComentarioCreateDto dto);
        Task<ResponseDto<ComentarioDto>> DeleteAsync(Guid id);
        Task<ResponseDto<ComentarioDto>> EditAsync(ComentarioEditDto dto, Guid id);
        Task<ResponseDto<List<ComentarioDto>>> GetComentarioByAsync(Guid id);
        Task<ResponseDto<List<ComentarioDto>>> GetComentarioListAsync();
    }
}
