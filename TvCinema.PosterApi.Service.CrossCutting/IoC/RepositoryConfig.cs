using Microsoft.Extensions.DependencyInjection;
using TvCinema.PosterApi.Service.Domain.Interfaces;
using TvCinema.PosterApi.Service.Infrastructure.Repositories;

namespace TvCinema.PosterApi.Service.CrossCutting.IoC
{
    public static class RepositoryConfig
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IPosterRepository, PosterRepository>();
        }
    }
}
