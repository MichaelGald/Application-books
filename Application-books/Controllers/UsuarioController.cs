using Application_books.Dtos.Common;
using Application_books.Dtos.Libros;
using Application_books.Dtos.Usuarios;
using Application_books.Services;
using Application_books.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application_books.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuariosServices _usuariosServices;

        public UsuarioController(IUsuariosServices usuariosServices)
        {
            this._usuariosServices = usuariosServices;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<UsuarioDto>>>> GetAll()
        {
            var response = await _usuariosServices.GetUsuariosListAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<UsuarioDto>>> Get(Guid id)
        {
            var response = await _usuariosServices.GetLUsuarioByAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<UsuarioDto>>> Create(UsuarioCreateDto dto)
        {
            var respose = await _usuariosServices.CreateAsync(dto);
            return StatusCode(respose.StatusCode, respose);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDto<UsuarioDto>>> Edit(UsuarioEditDto dto, Guid id)
        {
            var responde = await _usuariosServices.EditAsync(dto, id);
            return StatusCode(responde.StatusCode, responde);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<UsuarioDto>>> Delete(Guid id)
        {
            var response = await _usuariosServices.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
