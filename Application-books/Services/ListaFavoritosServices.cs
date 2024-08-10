using Application_books.Database;
using Application_books.Database.Entitties;
using Application_books.Dtos.Autor;
using Application_books.Dtos.Common;
using Application_books.Dtos.ListaFavoritos;
using Application_books.Services.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application_books.Services
{
    public class ListaFavoritosServices : IListaFavoritoServices
    {
        private readonly ApplicationbooksContext _context;
        private readonly IMapper _mapper;

        public ListaFavoritosServices(ApplicationbooksContext context, IMapper mapper) 
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<ResponseDto<List<ListaFavoritoDto>>> GetListaFavoritoListAsync()
        {
            var listaFavEntity = await _context.ListaFavoritos.ToListAsync();
            var listaFavDto = _mapper.Map<List<ListaFavoritoDto>>(listaFavEntity);

            return new ResponseDto<List<ListaFavoritoDto>>
            {
                StatusCode = 200,
                Status = true,
                Message = "Lista de Favoritos obtenida correctamente.",
                Data = listaFavDto,
            };
        }

        public async Task<ResponseDto<ListaFavoritoDto>> CreateAsync(ListaFavoritoCreateDto dto)
        {
            var listaFavEntity = _mapper.Map<ListaFavoritoEntity>(dto);
            _context.ListaFavoritos.Add(listaFavEntity);
            await _context.SaveChangesAsync();

            var listaFavDto = _mapper.Map<ListaFavoritoDto>(listaFavEntity);

            return new ResponseDto<ListaFavoritoDto>
            {
                StatusCode = 201,
                Status = true,
                Message = "Registro creado coreectamente.",
                Data = listaFavDto,
            };
        }

        public async Task<ResponseDto<ListaFavoritoDto>> EditAsync(ListaFavoritoEditDto dto, Guid id)
        {
            var listaFavEntity = await _context.ListaFavoritos.FirstOrDefaultAsync(e => e.IdListaFavorito == id);
            if (listaFavEntity is null)
            {
                return new ResponseDto<ListaFavoritoDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"El registro registro"
                };
            }
            _mapper.Map<ListaFavoritoEditDto, ListaFavoritoEntity>(dto, listaFavEntity);
            _context.ListaFavoritos.Update(listaFavEntity);
            await _context.SaveChangesAsync();

            var listaFavDto = _mapper.Map<ListaFavoritoDto>(listaFavEntity);
            return new ResponseDto<ListaFavoritoDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro editado correctamente.",
                Data = listaFavDto
            };
        }

        public async Task<ResponseDto<ListaFavoritoDto>> DeleteAsync(Guid id)
        {
            var listaFavEntity = await _context.ListaFavoritos.FirstOrDefaultAsync(x => x.IdListaFavorito == id);
            if (listaFavEntity == null)
            {
                return new ResponseDto<ListaFavoritoDto>
                {
                    StatusCode = 404,
                    Status = false,
                    Message = $"No se encontro el registro"
                };
            }

            _context.ListaFavoritos.Remove(listaFavEntity);
            await _context.SaveChangesAsync();
            return new ResponseDto<ListaFavoritoDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro borrado correctamente"
            };
        }
    }
}
