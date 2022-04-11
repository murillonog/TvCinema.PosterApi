using Microsoft.EntityFrameworkCore;
using TvCinema.PosterApi.Service.Domain.Entities;
using TvCinema.PosterApi.Service.Domain.Interfaces;
using TvCinema.PosterApi.Service.Infrastructure.Context;

namespace TvCinema.PosterApi.Service.Infrastructure.Repositories
{
    public class PosterRepository : IPosterRepository
    {
        protected ApplicationDbContext Db;
        protected DbSet<Posters> DbSet;
        public PosterRepository(ApplicationDbContext context)
        {
            Db = context;
            DbSet = Db.Set<Posters>();
        }
        public async Task<Posters?> GetByImdbId(string imdbId)
        {
            return await DbSet.FirstOrDefaultAsync(x => x.ImdbId == imdbId);
        }
    }
}
