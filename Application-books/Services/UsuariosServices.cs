using Application_books.Database;
using Application_books.Database.Entitties;
using Application_books.Dtos.Common;
using Application_books.Dtos.Libros;
using Application_books.Dtos.Usuarios;
using Application_books.Services.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application_books.Services
{
    public class UsuariosServices : IUsuariosServices
    {
        private readonly ApplicationbooksContext _booksContext;
        private readonly IMapper _mapper;

        public UsuariosServices(ApplicationbooksContext booksContext, IMapper mapper)
        {
            this._booksContext = booksContext;
            this._mapper = mapper;
        }

        public async Task<ResponseDto<List<UsuarioDto>>> GetUsuariosListAsync()
        {
            var usuariosEntity = await _booksContext.Usuarios.ToListAsync();
            var usuariosDtos = _mapper.Map<List<UsuarioDto>>(usuariosEntity);

            return new ResponseDto<List<UsuarioDto>>
            {
                StatusCode = 200,
                Status = true,
                Message = "Lista de usuarios obtenida correctamente.",
                Data = usuariosDtos,
            };
        }

        public async Task<ResponseDto<UsuarioDto>> GetUsuarioByAsync(Guid id)
        {
            //TODO: Agregar include autor para que no aparezca null
            var usuariosEntity = await _booksContext.Usuarios.FirstOrDefaultAsync(c => c.IdUsuario == id);
            if (usuariosEntity == null)
            {
                return new ResponseDto<UsuarioDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = "No se encontro registro."
                };
            }
            var usuarioDto = _mapper.Map<UsuarioDto>(usuariosEntity);
            return new ResponseDto<UsuarioDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro obtenido correctamente.",
                Data = usuarioDto,
            };
        }

        public async Task<ResponseDto<UsuarioDto>> CreateAsync(UsuarioCreateDto dto)
        {
            var UsuarioEntity = _mapper.Map<UsuarioEntity>(dto);
            _booksContext.Usuarios.Add(UsuarioEntity);
            await _booksContext.SaveChangesAsync();

            var usuarioDto = _mapper.Map<UsuarioDto>(UsuarioEntity);

            return new ResponseDto<UsuarioDto>
            {
                StatusCode = 201,
                Status = true,
                Message = "Reegistro creado coreectamente.",
                Data = usuarioDto,
            };
        }

        public async Task<ResponseDto<UsuarioDto>> EditAsync(UsuarioEditDto dto, Guid id)
        {
            var usuarioEntity = await _booksContext.Usuarios.FirstOrDefaultAsync(e => e.IdUsuario == id);
            if (usuarioEntity is null)
            {
                return new ResponseDto<UsuarioDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"Error en el registro"
                };
            }
            _mapper.Map<UsuarioEditDto, UsuarioEntity>(dto, usuarioEntity);
            _booksContext.Usuarios.Update(usuarioEntity);
            await _booksContext.SaveChangesAsync();

            var libroDto = _mapper.Map<UsuarioDto>(usuarioEntity);
            return new ResponseDto<UsuarioDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro editado correctamente.",
                Data = libroDto,
            };
        }

        public async Task<ResponseDto<UsuarioDto>> DeleteAsync(Guid id)
        {
            var usuarioEntity = await _booksContext.Usuarios.FirstOrDefaultAsync(x => x.IdUsuario == id);
            if (usuarioEntity == null)
            {
                return new ResponseDto<UsuarioDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"No se encontro el registro"
                };
            }

            _booksContext.Usuarios.Remove(usuarioEntity);
            await _booksContext.SaveChangesAsync();
            return new ResponseDto<UsuarioDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro borrado correctamente"
            };
        }
    }
}
