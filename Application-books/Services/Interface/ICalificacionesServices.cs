using Application_books.Dtos.Calificacion;
using Application_books.Dtos.Common;

namespace Application_books.Services.Interface
{
    public interface ICalificacionesServices
    {
        Task<ResponseDto<List<CalificacionDto>>> GetCalificacionesListAsync();
        Task<ResponseDto<CalificacionDto>> GetCalificacionByAsync(Guid id);
        Task<ResponseDto<CalificacionDto>> CreateAsync(CalificacionCreateDto dto);
        Task<ResponseDto<CalificacionDto>> EditAsync(CalificacionEditDto dto, Guid id);
        Task<ResponseDto<CalificacionDto>> DeleteAsync(Guid id);
    }
}
