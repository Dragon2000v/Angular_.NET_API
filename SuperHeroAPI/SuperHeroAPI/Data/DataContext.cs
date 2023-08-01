using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        /*public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 

        }*/
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
