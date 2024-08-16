using Application_books.Database.Entitties;
using Application_books.Dtos.Autor;
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
            MapsForAutor();
<<<<<<< HEAD
            MapsForCalificacion();
            MapsForMembresia();
            MapsForListaFavorito();
=======
>>>>>>> 7e0c0a2195fc86dd14460daf44473dd4f2af3fde
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
<<<<<<< HEAD
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
=======
>>>>>>> 7e0c0a2195fc86dd14460daf44473dd4f2af3fde
    }
}
