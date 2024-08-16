using Application_books.Dtos.Common;
using Application_books.Dtos.Membresia;
using Application_books.Dtos.Usuarios;

namespace Application_books.Services.Interface
{
    public interface IMembresiaServicio
    {
        Task<ResponseDto<MembresiaDto>> CreateAsync(MembresiaCreateDto dto);
        Task<ResponseDto<MembresiaDto>> DeleteAsync(Guid id);
        Task<ResponseDto<MembresiaDto>> EditAsync(MembresiaEditDto dto, Guid id);
        Task<ResponseDto<MembresiaDto>> GetMembresiaByAsync(Guid id);
        Task<ResponseDto<List<MembresiaDto>>> GetMembresiaListAsync();
    }
}
