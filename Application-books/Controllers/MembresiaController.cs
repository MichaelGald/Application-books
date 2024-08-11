using Application_books.Dtos.Common;
using Application_books.Dtos.Membresia;
using Application_books.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Application_books.Controllers
{
    [Route("api/membresia")]
    [ApiController]
    public class MembresiaController : Controller
    {
        private readonly IMembresiaServicio _membresiaServicio;

        public MembresiaController(IMembresiaServicio membresiaServicio) 
        {
            this._membresiaServicio = membresiaServicio;
        }
        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<MembresiaDto>>>> GetAll()
        {
            var response = await _membresiaServicio.GetMembresiaListAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<MembresiaDto>>> Get(Guid id)
        {
            var response = await _membresiaServicio.GetMembresiaByAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<MembresiaDto>>> Create(MembresiaCreateDto dto)
        {
            var respose = await _membresiaServicio.CreateAsync(dto);
            return StatusCode(respose.StatusCode, respose);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDto<MembresiaDto>>> Edit(MembresiaEditDto dto, Guid id)
        {
            var responde = await _membresiaServicio.EditAsync(dto, id);
            return StatusCode(responde.StatusCode, responde);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<MembresiaDto>>> Delete(Guid id)
        {
            var response = await _membresiaServicio.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
