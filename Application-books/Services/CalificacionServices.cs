using Application_books.Database;
using Application_books.Database.Entitties;
using Application_books.Dtos.Calificacion;
using Application_books.Dtos.Common;
using Application_books.Services.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application_books.Services
{
    public class CalificacionServices : ICalificacionesServices
    {
        private readonly ApplicationbooksContext _context;
        private readonly IMapper _mapper;

        public CalificacionServices(ApplicationbooksContext context, IMapper mapper) 
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<ResponseDto<List<CalificacionDto>>> GetCalificacionesListAsync()
        {
            var calificacionEntity = await _context.Calificaciones.ToListAsync();
            var CalificacionDtos = _mapper.Map<List<CalificacionDto>>(calificacionEntity);

            return new ResponseDto<List<CalificacionDto>>
            {
                StatusCode = 200,
                Status = true,
                Message = "Lista de calificacion obtenida correctamente.",
                Data = CalificacionDtos,
            };
        }
        public async Task<ResponseDto<CalificacionDto>> GetCalificacionByAsync(Guid id)
        {
            var calificacionEntity = await _context.Calificaciones.FirstOrDefaultAsync(c => c.IdCalificacion == id);
            if (calificacionEntity == null)
            {
                return new ResponseDto<CalificacionDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = "No se encontro registro."
                };
            }
            var calificacionDto = _mapper.Map<CalificacionDto>(calificacionEntity);
            return new ResponseDto<CalificacionDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro obtenido correctamente.",
                Data = calificacionDto,
            };
        }
        public async Task<ResponseDto<CalificacionDto>> CreateAsync(CalificacionCreateDto dto)
        {
            var calificacionEntity = _mapper.Map<CalificacionEntity>(dto);
            _context.Calificaciones.Add(calificacionEntity);
            await _context.SaveChangesAsync();

            var calificacionDto = _mapper.Map<CalificacionDto>(calificacionEntity);

            return new ResponseDto<CalificacionDto>
            {
                StatusCode = 201,
                Status = true,
                Message = "Registro creado coreectamente.",
                Data = calificacionDto,
            };
        }
        public async Task<ResponseDto<CalificacionDto>> EditAsync(CalificacionEditDto dto, Guid id)
        {
            var calificacionEntity = await _context.Calificaciones.FirstOrDefaultAsync(e => e.IdCalificacion == id);
            if (calificacionEntity is null)
            {
                return new ResponseDto<CalificacionDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"El registro registro"
                };
            }
            _mapper.Map<CalificacionEditDto, CalificacionEntity>(dto, calificacionEntity);
            _context.Calificaciones.Update(calificacionEntity);
            await _context.SaveChangesAsync();

            var calificacionDto = _mapper.Map<CalificacionDto>(calificacionEntity);
            return new ResponseDto<CalificacionDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro editado correctamente.",
                Data = calificacionDto
            };
        }
        public async Task<ResponseDto<CalificacionDto>> DeleteAsync(Guid id)
        {
            var calificacionEntity = await _context.Calificaciones.FirstOrDefaultAsync(x => x.IdCalificacion == id);
            if (calificacionEntity == null)
            {
                return new ResponseDto<CalificacionDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"No se encontro el registro"
                };
            }

            _context.Calificaciones.Remove(calificacionEntity);
            await _context.SaveChangesAsync();
            return new ResponseDto<CalificacionDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro borrado correctamente"
            };
        }
    }
}
