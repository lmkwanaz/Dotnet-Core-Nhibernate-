using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using LwandileAPIs.Data;

using System.IO;
using Ninject;
using Ninject.Core.Behavior;

namespace LwandileAPIs
{
    public class Startup
    {
        private Lwandile.Data.Models.ConnectionString _conn = null;
        private Lwandile.Domain.ILwandieDomain _domain;

        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;
    
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllers();

            //I need this line for Entity Framework
            services.AddDbContext<MusicLibrary>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MusicLibrary")));

            //I need this for Nhibernate 
            services.Configure<Lwandile.Data.Models.ConnectionString>(Configuration.GetSection("ConnectionString"));


            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Place Info Service API",
                    Version = "v2",
                    Description = "Sample service for Learner",
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v2/swagger.json", "PlaceInfo Services"));
        }
    }
}
