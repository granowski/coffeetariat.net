using System.Data.SqlClient;
using Coffeetariat.UnpopularOpinions.Database;
using Coffeetariat.UnpopularOpinions.W3.DataSources;
using Coffeetariat.UnpopularOpinions.W3.Interfaces;
using Coffeetariat.UnpopularOpinions.W3.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace Coffeetariat.UnpopularOpinions.W3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSingleton<IOpinionsDataSource, XmlOpinionsFile>();
            services.AddSingleton<IOpinionsRepository, OpinionsRepository>();

            services.AddDbContext<Database.OpinionContext>(options =>
            {
                Configurator.Configuration dbconfig =
                    new Configurator.Configuration(
                        Configuration["Database:Host"] ?? string.Empty, 
                        Configuration["Database:Owner"] ?? string.Empty, 
                        Configuration["Database:OwnerPassword"] ?? string.Empty, 
                        Configuration["Database:Name"] ?? "unnamed");

                dbconfig.EnsureValidOrThrow();
            
                var connectionString = Configurator.GenerateConnectionString(dbconfig);
            
//                Configurator.WriteConfigurationToFile(null, dbconfig);
                Configurator.WriteConfigurationToOut(System.Console.OpenStandardOutput(), dbconfig);
                options.UseNpgsql(new NpgsqlConnection(connectionString));
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseFileServer();
            
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
