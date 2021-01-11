using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ParkingCitationReviews.Business;
using ParkingCitationReviews.Business.Interfaces;
using ParkingCitationReviewApp.Model;
using Microsoft.EntityFrameworkCore;
using ParkingCitationReviewApp.Models;
using ParkingCitationReviews.DataAccess;
using Microsoft.AspNetCore.HttpOverrides;

namespace ParkingCitationReviewApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration,IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(env.ContentRootPath)
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
              .AddEnvironmentVariables();

            //Configuration = configuration;
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }
        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<recaptcha>(Configuration.GetSection("recaptcha"));
            services.AddDbContext<ParkingReviewDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Myconnection")));
            services.AddRazorPages();
            services.AddSingleton<IParkingCitationReviewsTasks, ParkingCitationReviewsTasks>();
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders =
                    ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseForwardedHeaders();
            app.UseHsts();



            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //}


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
