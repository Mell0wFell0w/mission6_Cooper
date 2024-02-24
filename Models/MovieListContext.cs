using Microsoft.EntityFrameworkCore;

namespace mission6_Cooper.Models
{
    public class MovieListContext : DbContext
    {
        public MovieListContext(DbContextOptions<MovieListContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
