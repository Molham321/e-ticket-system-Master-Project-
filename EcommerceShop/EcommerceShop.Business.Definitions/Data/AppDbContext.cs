using EcommerceShop.Business.Definitions.Data.Config;
using Microsoft.EntityFrameworkCore;


namespace EcommerceShop.Business.Definitions.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBilder)
        {
            // Configure entity relationships using entity configurations
            modelBilder.ApplyConfiguration(new Actor_MovieConfiguration());

            base.OnModelCreating(modelBilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
