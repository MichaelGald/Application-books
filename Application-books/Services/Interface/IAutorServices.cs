using Application_books.Dtos.Autor;
using Application_books.Dtos.Common;


namespace Application_books.Services.Interface
{
    public interface IAutorServices
    {
        Task<ResponseDto<List<AutorDto>>> GetAutorListAsync();
        Task<ResponseDto<AutorDto>> GetAutorByAsync(Guid id);
        Task<ResponseDto<AutorDto>> CreateAsync(AutorCreateDto dto);
        Task<ResponseDto<AutorDto>> EditAsync(AutorEditDto dto, Guid id);
        Task<ResponseDto<AutorDto>> DeleteAsync(Guid id);
    }
}
