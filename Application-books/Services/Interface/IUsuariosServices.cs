using Application_books.Dtos.Common;
using Application_books.Dtos.Usuarios;

namespace Application_books.Services.Interface
{
    public interface IUsuariosServices
    {
        Task<ResponseDto<UsuarioDto>> CreateAsync(UsuarioCreateDto dto);
        Task<ResponseDto<UsuarioDto>> DeleteAsync(Guid id);
        Task<ResponseDto<UsuarioDto>> EditAsync(UsuarioEditDto dto, Guid id);
        Task<ResponseDto<UsuarioDto>> GetUsuarioByAsync(Guid id);
        Task<ResponseDto<List<UsuarioDto>>> GetUsuariosListAsync();
    }
}
