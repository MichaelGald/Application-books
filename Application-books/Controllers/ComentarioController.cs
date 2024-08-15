using Application_books.Dtos.Calificacion;
using Application_books.Dtos.Comentarios;
using Application_books.Dtos.Common;
using Application_books.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Application_books.Controllers
{
    [Route("api/comentario")]
    [ApiController]
    public class ComentarioController : Controller
    {
        private readonly IComentariosServices _comentarioServices;

        public ComentarioController(IComentariosServices comentarioServices)
        {
            this._comentarioServices = comentarioServices;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<ComentarioDto>>>> GetAll()
        {
            var response = await _comentarioServices.GetComentarioListAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<ComentarioDto>>> Get(Guid id)
        {
            var response = await _comentarioServices.GetComentarioByAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<ComentarioDto>>> Create(ComentarioCreateDto dto)
        {
            var respose = await _comentarioServices.CreateAsync(dto);
            return StatusCode(respose.StatusCode, respose);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDto<CalificacionDto>>> Edit(ComentarioEditDto dto, Guid id)
        {
            var responde = await _comentarioServices.EditAsync(dto, id);
            return StatusCode(responde.StatusCode, responde);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<ComentarioDto>>> Delete(Guid id)
        {
            var response = await _comentarioServices.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
