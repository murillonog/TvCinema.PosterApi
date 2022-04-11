using TvCinema.PosterApi.Service.Application.DTOs;

namespace TvCinema.PosterApi.Service.Application.Interfaces
{
    public interface IPosterService
    {
        Task<PostersDto> GetByImdbId(string imdbId);
    }
}
