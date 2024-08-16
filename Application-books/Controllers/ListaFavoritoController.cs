using Application_books.Dtos.Autor;
using Application_books.Dtos.Common;
using Application_books.Dtos.ListaFavoritos;
using Application_books.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Application_books.Controllers
{
    [Route("api/listafavoritos")]
    [ApiController]
    public class ListaFavoritoController : Controller
    {
        private readonly IListaFavoritoServices _listaFavoritoServices;

        public ListaFavoritoController(IListaFavoritoServices listaFavoritoServices)
        {
            this._listaFavoritoServices = listaFavoritoServices;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<ListaFavoritoDto>>>> GetAll()
        {
            var response = await _listaFavoritoServices.GetListaFavoritoListAsync();
            return StatusCode(response.StatusCode, response);
        }
        [HttpPost]
        public async Task<ActionResult<ResponseDto<ListaFavoritoDto>>> Create(ListaFavoritoCreateDto dto)
        {
            var respose = await _listaFavoritoServices.CreateAsync(dto);
            return StatusCode(respose.StatusCode, respose);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDto<ListaFavoritoDto>>> Edit(ListaFavoritoEditDto dto, Guid id)
        {
            var responde = await _listaFavoritoServices.EditAsync(dto, id);
            return StatusCode(responde.StatusCode, responde);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<ListaFavoritoDto>>> Delete(Guid id)
        {
            var response = await _listaFavoritoServices.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
