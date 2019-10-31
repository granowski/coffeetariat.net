using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Coffeetariat.UnpopularOpinions.Database
{
    public class OpinionContext : DbContext
    {
        public DbSet<Entities.Opinion> Opinions { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql(new NpgsqlConnection("Host=localhost;Database=opinions.2019.10.29;Username=granowski;Password=FuckingKepler22b!@"));
        }
    }
}