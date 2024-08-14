using Application_books.Database.Entitties;
using Application_books.Dtos.Autor;
using Application_books.Dtos.Calificacion;
using Application_books.Dtos.Libros;
using Application_books.Dtos.ListaFavoritos;
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
            MapsForListaFavorito();
        }

        private void MapsForLibros()
        {
        CreateMap<LibroEntity, LibroDto>()
        .ForMember(dest => dest.Promedio, opt => opt.MapFrom(src =>
        src.Calificaciones.Any() ? Math.Round(src.Calificaciones.Average(c => c.Puntuacion), 1) : 0));
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
        private void MapsForListaFavorito()
        {
            CreateMap<ListaFavoritoEntity, ListaFavoritoDto>();
            CreateMap<ListaFavoritoCreateDto, ListaFavoritoEntity>();
            CreateMap<ListaFavoritoEditDto, ListaFavoritoEntity>();
        }
    }
}
