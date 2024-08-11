using Application_books.Database;
using Application_books.Database.Entitties;
using Application_books.Dtos.Common;
using Application_books.Dtos.Membresia;
using Application_books.Services.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application_books.Services
{
    public class MembresiaServices : IMembresiaServicio
    {
        private readonly ApplicationbooksContext _context;
        private readonly IMapper _mapper;

        public MembresiaServices(ApplicationbooksContext context, IMapper mapper) 
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<ResponseDto<List<MembresiaDto>>> GetMembresiaListAsync()
        {
            var membresiaEntities = await _context.Membresias.ToListAsync();

            foreach (var membresiaEntity in membresiaEntities)
            {
                ExpiracionMembresia(membresiaEntity);
            }

            var membresiaDtos = _mapper.Map<List<MembresiaDto>>(membresiaEntities);

            return new ResponseDto<List<MembresiaDto>>
            {
                StatusCode = 200,
                Status = true,
                Message = "Lista de toda las membresias obtenida correctamente.",
                Data = membresiaDtos,
            };
        }
        public async Task<ResponseDto<MembresiaDto>> GetMembresiaByAsync(Guid id)
        {
            var membresiaEntity = await _context.Membresias.FirstOrDefaultAsync(c => c.IdMembresia == id);
            if (membresiaEntity == null)
            {
                return new ResponseDto<MembresiaDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = "No se encontro registro."
                };
            }
            ExpiracionMembresia(membresiaEntity);
            var membresiaDto = _mapper.Map<MembresiaDto>(membresiaEntity);

            return new ResponseDto<MembresiaDto>
            {
               StatusCode = 200,
               Status = true,
               Message = "Registro obtenido correctamente.",
               Data = membresiaDto,
            };
        }
        public async Task<ResponseDto<MembresiaDto>> CreateAsync(MembresiaCreateDto dto)
        {
            var membresiaEntity = _mapper.Map<MembresiaEntity>(dto);

            membresiaEntity = CalcularMembresia(membresiaEntity);
            _context.Membresias.Add(membresiaEntity);

            await _context.SaveChangesAsync();
            var membresiaDto = _mapper.Map<MembresiaDto>(membresiaEntity);

            return new ResponseDto<MembresiaDto>
            {
                StatusCode = 201,
                Status = true,
                Message = "Reegistro creado coreectamente.",
                Data = membresiaDto,
            };
        }
        public async Task<ResponseDto<MembresiaDto>> EditAsync(MembresiaEditDto dto, Guid id)
        {
            var membresiaEntity = await _context.Membresias.FirstOrDefaultAsync(e => e.IdMembresia == id);
            if (membresiaEntity is null)
            {
                return new ResponseDto<MembresiaDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"El registro registro"
                };
            }
            _mapper.Map<MembresiaEditDto, MembresiaEntity>(dto, membresiaEntity);
            membresiaEntity = CalcularMembresia(membresiaEntity);

            _context.Membresias.Update(membresiaEntity);

            await _context.SaveChangesAsync();
            var membresiaDto = _mapper.Map<MembresiaDto>(membresiaEntity);

            return new ResponseDto<MembresiaDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro editado correctamente.",
                Data = membresiaDto
            };
        }
        public async Task<ResponseDto<MembresiaDto>> DeleteAsync(Guid id)
        {
            var librosEntity = await _context.Membresias.FirstOrDefaultAsync(x => x.IdMembresia == id);
            if (librosEntity == null)
            {
                return new ResponseDto<MembresiaDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"No se encontro el registro"
                };
            }

            _context.Membresias.Remove(librosEntity);
            await _context.SaveChangesAsync();
            return new ResponseDto<MembresiaDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro borrado correctamente"
            };
        }
        private MembresiaEntity CalcularMembresia(MembresiaEntity entity)
        {
            if (entity.ActivaMembresia)
            {
                if (entity.FechaFin == null || entity.FechaFin.Value <= DateTime.Now)
                {
                    entity.FechaInicio = DateTime.Now;
                    entity.FechaFin = DateTime.Now.AddDays(30);
                }
                entity.FechaCancelacion = null;
            }
            else
            {
                entity.FechaCancelacion = DateTime.Now;
            }
            return entity;
        }
        private void ExpiracionMembresia(MembresiaEntity entity)
        {
            if (entity.FechaFin.HasValue && entity.FechaFin.Value <= DateTime.Now)
            {
                entity.ActivaMembresia = false;
                entity.FechaFin = null;
            }
        }
    }
}
