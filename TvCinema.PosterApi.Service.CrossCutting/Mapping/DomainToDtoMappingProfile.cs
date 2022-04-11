using AutoMapper;
using TvCinema.PosterApi.Service.Application.DTOs;
using TvCinema.PosterApi.Service.Domain.Entities;

namespace TvCinema.PosterApi.Service.CrossCutting.Mapping
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Posters, PostersDto>().ReverseMap();
        }
    }
}
