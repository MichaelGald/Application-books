using Application_books.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application_books.Controllers
{
    [Route("api/libros")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibrosServices _librosServices;

        public LibroController(ILibrosServices librosServices)
        {
            this._librosServices = librosServices;
        }
    }
} 
