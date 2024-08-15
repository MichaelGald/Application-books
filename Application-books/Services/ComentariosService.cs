using Application_books.Database.Entitties;
using Application_books.Database;
using Application_books.Dtos.Calificacion;
using Application_books.Dtos.Common;
using Application_books.Services.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Application_books.Dtos.Comentarios;

namespace Application_books.Services
{
    public class ComentariosService : IComentariosServices
    {
        private readonly ApplicationbooksContext _context;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public ComentariosService(ApplicationbooksContext context, IMapper mapper, IAuthService authService)
        {
            this._context = context;
            this._mapper = mapper;
            this._authService = authService;
        }
        public async Task<ResponseDto<List<ComentarioDto>>> GetComentarioListAsync()
        {
            var comentarioEntity = await _context.Comentarios.ToListAsync();
            var ComentariosDtos = _mapper.Map<List<ComentarioDto>>(comentarioEntity);

            return new ResponseDto<List<ComentarioDto>>
            {
                StatusCode = 200,
                Status = true,
                Message = "Lista de calificacion obtenida correctamente.",
                Data = ComentariosDtos,
            };
        }
        public async Task<ResponseDto<ComentarioDto>> GetComentarioByAsync(Guid id)
        {
            var comentarioEntity = await _context.Comentarios.FirstOrDefaultAsync(c => c.IdComentario == id);
            if (comentarioEntity == null)
            {
                return new ResponseDto<ComentarioDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = "No se encontro registro."
                };
            }
            var comentarioDto = _mapper.Map<ComentarioDto>(comentarioEntity);
            return new ResponseDto<ComentarioDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro obtenido correctamente.",
                Data = comentarioDto,
            };
        }
        public async Task<ResponseDto<ComentarioDto>> CreateAsync(ComentarioCreateDto dto)
        {
            var comentarioEntity = _mapper.Map<ComentarioEntity>(dto);

            var userIdString = _authService.GetUserId();

            _context.Comentarios.Add(comentarioEntity);
            await _context.SaveChangesAsync();

            var calificacionDto = _mapper.Map<ComentarioDto>(comentarioEntity);

            return new ResponseDto<ComentarioDto>
            {
                StatusCode = 201,
                Status = true,
                Message = "Registro creado coreectamente.",
                Data = calificacionDto,
            };
        }
        public async Task<ResponseDto<ComentarioDto>> EditAsync(ComentarioEditDto dto, Guid id)
        {
            var comentarioEntity = await _context.Comentarios.FirstOrDefaultAsync(e => e.IdComentario == id);
            if (comentarioEntity is null)
            {
                return new ResponseDto<ComentarioDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"El registro no se encontro"
                };
            }
            _mapper.Map(dto, comentarioEntity);

            _context.Comentarios.Update(comentarioEntity);
            await _context.SaveChangesAsync();

            var calificacionDto = _mapper.Map<ComentarioDto>(comentarioEntity);
            return new ResponseDto<ComentarioDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro editado correctamente.",
                Data = calificacionDto
            };
        }
        public async Task<ResponseDto<ComentarioDto>> DeleteAsync(Guid id)
        {
            var comentarioEntity = await _context.Comentarios.FirstOrDefaultAsync(x => x.IdComentario == id);
            if (comentarioEntity == null)
            {
                return new ResponseDto<ComentarioDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"No se encontro el registro"
                };
            }

            _context.Comentarios.Remove(comentarioEntity);
            await _context.SaveChangesAsync();
            return new ResponseDto<ComentarioDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro borrado correctamente"
            };
        }
    }
}
