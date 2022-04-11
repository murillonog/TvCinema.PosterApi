using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TvCinema.PosterApi.Service.Infrastructure.Context;

namespace TvCinema.PosterApi.Service.CrossCutting.IoC
{
    public static class DataBaseConfig
    {
        public static void ConfigureDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("ConnectionPosters")));
        }
    }
}
