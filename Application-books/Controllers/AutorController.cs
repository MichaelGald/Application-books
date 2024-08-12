using Application_books.Dtos.Autor;
using Application_books.Dtos.Common;
using Application_books.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Application_books.Controllers
{
    [Route("api/autor")]
    [ApiController]
    public class AutorController : Controller
    {
        private readonly IAutorServices _autorServices;

        public AutorController(IAutorServices autorServices) 
        {
            this._autorServices = autorServices;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<AutorDto>>>> GetAll()
        {
            var response = await _autorServices.GetAutorListAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<AutorDto>>> Get(Guid id)
        {
            var response = await _autorServices.GetAutorByAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<AutorDto>>> Create(AutorCreateDto dto)
        {
            var respose = await _autorServices.CreateAsync(dto);
            return StatusCode(respose.StatusCode, respose);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDto<AutorDto>>> Edit(AutorEditDto dto, Guid id)
        {
            var responde = await _autorServices.EditAsync(dto, id);
            return StatusCode(responde.StatusCode, responde);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<AutorDto>>> Delete(Guid id)
        {
            var response = await _autorServices.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
