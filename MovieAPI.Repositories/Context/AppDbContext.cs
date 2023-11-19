using Microsoft.EntityFrameworkCore;
using MovieAPI.Models.Entities;

namespace MovieAPI.Entities.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9OHK71U; Database=MovieApiDB; Trusted_Connection=True;");
        }


    }
}
