using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrashUtahProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.ML.OnnxRuntime;

namespace CrashUtahProject
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
            services.AddControllersWithViews();
            var password = Environment.GetEnvironmentVariable("password");
            services.AddDbContext<AccidentDbContext>(options =>
            {
                options.UseMySql($"Data Source=crash-utah-3.ctwsokicb6qn.us-east-1.rds.amazonaws.com;Initial Catalog=AccidentDatabase;username=root;password={password}");

            });
            services.AddScoped<IAccidentRepository, EFAccidentRepository>();

            services.AddDbContext<AppIdentityDbContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:IdentityConnection"]);
                //options.UseMySql($"Data Source=crash-utah-3.ctwsokicb6qn.us-east-1.rds.amazonaws.com;Initial Catalog=Identity;username=root;password={password}");

            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppIdentityDbContext>()
                    .AddDefaultTokenProviders();

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSingleton<InferenceSession>(
              new InferenceSession("wwwroot/INTEX_model.onnx")
            );

            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 12;
                options.Password.RequiredUniqueChars = 1;
            });
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.Use(async (context, next) =>
            {
                //context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'; script-src 'self'; style-src 'self';");
                //await next();
                context.Response.Headers.Add("Content-Security-Policy-Report-Only", "default-src 'self'; report-uri /cspreport");
                await next();

            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "searchpage",
                    pattern: "{id}/{city}/{pageNum}",
                    defaults: new { Controller = "Home", Action = "Data" }
                    );

                endpoints.MapControllerRoute(
                    name: "crashpage",
                    pattern: "{id}",
                    defaults: new { Controller = "Home", action = "Crash" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();

                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");
            });

            //IdentitySeedData.EnsurePopulated(app);
        }
    }
}
