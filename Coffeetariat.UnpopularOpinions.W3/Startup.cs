using Coffeetariat.UnpopularOpinions.W3.DataSources;
using Coffeetariat.UnpopularOpinions.W3.Interfaces;
using Coffeetariat.UnpopularOpinions.W3.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
