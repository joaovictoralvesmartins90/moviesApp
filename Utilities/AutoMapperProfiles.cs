﻿using AutoMapper;
using MoviesApp.DTOs;
using MoviesApp.Entities;

namespace MoviesApp.Utilities
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Genre, GenreDTO>();
            CreateMap<CreateGenreDTO, Genre>();
        }
    }
}
