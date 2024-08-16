using Application_books.Database.Entitties;
using Application_books.Dtos.Autor;
<<<<<<< HEAD
=======
using Application_books.Dtos.Calificacion;
using Application_books.Dtos.Comentarios;
>>>>>>> rama-backend
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
<<<<<<< HEAD
=======
>>>>>>> 7e0c0a2195fc86dd14460daf44473dd4f2af3fde
=======
            MapsForComentario();
>>>>>>> rama-backend
        }

        private void MapsForLibros()
        {
<<<<<<< HEAD
            //Libro
            CreateMap<LibroEntity, LibroDto>();
=======
        CreateMap<LibroEntity, LibroDto>()
        .ForMember(dest => dest.Promedio, opt => opt.MapFrom(src =>
        src.Calificaciones.Any() ? Math.Round(src.Calificaciones.Average(c => c.Puntuacion), 1) : 0));
>>>>>>> rama-backend
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
<<<<<<< HEAD
=======
>>>>>>> 7e0c0a2195fc86dd14460daf44473dd4f2af3fde
=======

        private void MapsForComentario()
        {
            CreateMap<ComentarioEntity, ComentarioDto>();
            CreateMap<ComentarioCreateDto, ComentarioEntity>();
            CreateMap<ComentarioEditDto, ComentarioEntity>();
        }
>>>>>>> rama-backend
    }
}
