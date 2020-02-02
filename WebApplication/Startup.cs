using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication.Models;

namespace WebApplication
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private readonly IConfiguration _configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = _configuration.GetConnectionString("DefaultConnection");
            var options = new DbContextOptionsBuilder<BlogContext>()
                .UseSqlServer(connection)
                .Options;
            
            var context = new BlogContext(options);

            services.AddScoped(provider => new BlogBuilder()
                .Repository(new SqlRepository(context))
                .Build());

            
            
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware();
            }
            
            app.UseStaticFiles();

            app.UseRouting();

            app.UseMvc(endpoints =>
            {
                endpoints.MapRoute(
                    name: "default",
                    template: "api/{controller=Home}/{action=Index}");
                endpoints.MapSpaFallbackRoute("spa-fallback", new 
                    { controller = "Home", action = "Index" });
            });
        }
    }
}