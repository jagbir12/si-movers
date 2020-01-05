using Microsoft.EntityFrameworkCore;

namespace si_movers
{
    class MoversDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = USER;Database=Movers;Trusted_Connection=True;");
        }
    }
}
