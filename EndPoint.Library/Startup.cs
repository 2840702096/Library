using Library.Application.Interfaces.Context;
using Library.Application.Interfaces.FacadPaterns.BooksFacadPatern;
using Library.Application.Interfaces.FacadPaterns.HomeFacadPatern;
using Library.Application.Interfaces.FacadPaterns.MessagesFacadPatern;
using Library.Application.Interfaces.FacadPaterns.Users_BooksFacadPatern;
using Library.Application.Interfaces.FacadPaterns.UsersFacadPatern;
using Library.Application.Services.Books.FacadPatern;
using Library.Application.Services.Home.FacadPtern;
using Library.Application.Services.Messages.FacadPatern;
using Library.Application.Services.Users.FacadPatern;
using Library.Application.Services.Users_Books.FacadPatern;
using Library.Persistence.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EndPoint.Library
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

            #region Scopes

            services.AddScoped<IDataBaseContext, DataBaseContext>();
            services.AddScoped<IUsersFacadPatern, UsersFacadPatern>();
            services.AddScoped<IBooksFacadPatern, BooksFacadPatern>();
            services.AddScoped<IUsers_BooksFacadPatern, Users_BooksFacadPatern>();
            services.AddScoped<IMessagesFacadPaternService, MessagesFacadPaternService>();
            services.AddScoped<IHomeFacadPatern, HomeFacadPatern>();

            #endregion

            #region Context

            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LibraryConnectionString")));

            #endregion
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
