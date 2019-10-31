using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Coffeetariat.UnpopularOpinions.Database
{
    public class OpinionContext : DbContext
    {
        public DbSet<Entities.Opinion> Opinions { get; set; }

        public OpinionContext(DbContextOptions<OpinionContext> options)
        {
            
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string filename = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile(filename).Build();

            Configurator.Configuration dbconfig =
                new Configurator.Configuration(
                    configuration["Database:Host"] ?? string.Empty, 
                    configuration["Database:Owner"] ?? string.Empty, 
                    configuration["Database:OwnerPassword"] ?? string.Empty, 
                    configuration["Database:Name"] ?? "unnamed");

            dbconfig.EnsureValidOrThrow();
            
            var connectionString = Configurator.GenerateConnectionString(dbconfig);

            string tempConnectionInformationFile = Path.GetTempFileName();
            System.Console.WriteLine("connection information for this instance -> " +
                                     tempConnectionInformationFile);
            
            Configurator.WriteConfigurationToFile(tempConnectionInformationFile, dbconfig);

            optionsBuilder.UseNpgsql(new NpgsqlConnection(connectionString));
        }
    }
}