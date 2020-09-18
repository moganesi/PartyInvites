using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PartyInvites.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace PartyInvites
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
                                  });
            });
            //string v = Configuration.GetConnectionString("");
            services.AddDbContext<CalcDbContext>(opts => {
                opts.UseSqlServer(Configuration["ConnectionStrings:CalcConnection"]);
                opts.EnableSensitiveDataLogging(true);
            });
            services.AddDbContext<IdentityDataContext>(options =>
options.UseSqlServer(Configuration["ConnectionStrings:Identity"]));
            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<IdentityDataContext>();

            services.AddControllersWithViews().AddJsonOptions(options => {
                // set this option to TRUE to indent the JSON output
                options.JsonSerializerOptions.WriteIndented = true;
                // set this option to NULL to use PascalCase instead of
                // camelCase (default)
                options.JsonSerializerOptions.PropertyNamingPolicy =
                null;
            }); ;
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration config, IServiceProvider services)//, ILogger<Startup> logger)
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
            app.UseAuthentication();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

           


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //IdentitySeedData.SeedDatabase(services).Wait();
        }
    }
}
