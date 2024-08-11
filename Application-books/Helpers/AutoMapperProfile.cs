using Application_books.Database.Entitties;
using Application_books.Dtos.Autor;
using Application_books.Dtos.Calificacion;
using Application_books.Dtos.Libros;
using Application_books.Dtos.Membresia;
using Application_books.Dtos.Usuarios;
using AutoMapper;

namespace Application_books.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            MapsForLibros(); 
            MapsForUsuario();
            MapsForAutor();
            MapsForCalificacion();
            MapsForMembresia();
        }

        private void MapsForLibros()
        {
            CreateMap<LibroEntity, LibroDto>();
            CreateMap<LibroCreateDto, LibroEntity>();
            CreateMap<LibroEditDto, LibroEntity>();
        }

        private void MapsForUsuario()
        {
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
        private void MapsForCalificacion()
        {
            CreateMap<CalificacionEntity, CalificacionDto>();
            CreateMap<CalificacionCreateDto, CalificacionEntity>();
            CreateMap<CalificacionEditDto, CalificacionEntity>();
        }
        private void MapsForMembresia()
        {
            CreateMap<MembresiaEntity, MembresiaDto>();
            CreateMap<MembresiaCreateDto, MembresiaEntity>();
            CreateMap<MembresiaEditDto, MembresiaEntity>();
        }
    }
}
