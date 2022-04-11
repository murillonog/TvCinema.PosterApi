using TvCinema.PosterApi.Service.Domain.Entities;

namespace TvCinema.PosterApi.Service.Domain.Interfaces
{
    public interface IPosterRepository
    {
        Task<Posters?> GetByImdbId(string imdbId);
    }
}
