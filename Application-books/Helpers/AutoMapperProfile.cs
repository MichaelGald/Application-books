﻿using Application_books.Database.Entitties;
using Application_books.Dtos.Libros;
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
            CreateMap<LibroEntity, LibroDto>();
            CreateMap<LibroEditDto, LibroEntity>();
            //.ForMember(dest => dest.IdLibro, opt => opt.Ignore()); // No mapees el Id si es una PK
            CreateMap<LibroEditDto, LibroEntity>();
        }
    }
}
