using Application_books.Database.Entitties;
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
    }
}
