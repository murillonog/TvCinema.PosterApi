using Microsoft.EntityFrameworkCore;
using TvCinema.PosterApi.Service.Domain.Entities;

namespace TvCinema.PosterApi.Service.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public DbSet<Posters> Posters { get; set; }
    }
}
