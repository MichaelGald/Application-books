using Application_books.Database.Entitties;
using Application_books.Dtos.Autor;
using Application_books.Dtos.Libros;
using Application_books.Dtos.Usuarios;
using AutoMapper;

namespace Application_books.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            MapsForLibros(); 
            MapsForAutor();
        }

        private void MapsForLibros()
        {
            //Libro
            CreateMap<LibroEntity, LibroDto>();
            CreateMap<LibroCreateDto, LibroEntity>();
            CreateMap<LibroEditDto, LibroEntity>();

            //Usuarios
            CreateMap<UsuarioEntity, UsuarioDto>();
            CreateMap<UsuarioCreateDto, UsuarioEntity>();
            CreateMap<UsuarioEditDto, UsuarioEntity>();
        }
        private void MapsForAutor()
        {
            CreateMap<AutorEntity, AutorDto>();
            CreateMap<AutorCreateDto, AutorEntity>();
            CreateMap<AutorEditDto, AutorEntity>();
        }
    }
}
