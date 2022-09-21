using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string DBTipo = Configuration["DBTipo"];
            string DBConnStr = Configuration.GetConnectionString(DBTipo);

            switch (DBTipo)
            {
                case "SqlServer":
                    services.AddDbContext<AcademiaDB>(options =>
                        options.UseSqlServer(DBConnStr)
                    );
                    break;
                case "Postgres":
                    services.AddDbContext<AcademiaDB>(options =>
                        options.UseNpgsql(DBConnStr)
                    );
                    break;
                default: // Por defecto usa la memoria como base de datos
                    services.AddDbContext<AcademiaDB>(options =>
                        options.UseInMemoryDatabase(DBConnStr)
                    );
                    break;
            }            

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
