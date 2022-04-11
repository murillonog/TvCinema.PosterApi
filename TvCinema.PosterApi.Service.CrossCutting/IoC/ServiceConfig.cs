using Microsoft.Extensions.DependencyInjection;
using TvCinema.PosterApi.Service.Application.Interfaces;
using TvCinema.PosterApi.Service.Application.Services;

namespace TvCinema.PosterApi.Service.CrossCutting.IoC
{
    public static class ServiceConfig
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IPosterService, PosterService>();
        }
    }
}
