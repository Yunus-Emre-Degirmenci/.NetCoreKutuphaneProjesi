using FluentValidation.AspNetCore;
using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Base;
using Library.RepositoryPattern.Concrete;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Startup
    {
        readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // veri tabaný baðlantýsý
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(_configuration["ConnectionStrings:Mssql"]));

            services.AddControllersWithViews().AddFluentValidation(fv=>fv.RegisterValidatorsFromAssemblyContaining<Startup>());


            // Repository tanýmlama

            //services.AddScoped<IRepository<Tbl_BookType>, Repository<Tbl_BookType>>();
            services.AddScoped<IBookTypeRepository, BookTypeRepository>();
            services.AddScoped<IRepository<User>, Repository<User>>();
            //services.AddScoped<IRepository<Tbl_Author>, Repository<Tbl_Author>>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();


            //kimlik doðrulama iþlemi
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Auth/Login";
                options.Cookie.Name = "UserDetail";
                options.AccessDeniedPath = "/Auth/Login";
            });


            // yetki tanýmlama iþlemi
            services.AddAuthorization(options=>
            {
                options.AddPolicy("AdminPolicy",policy=>policy.RequireClaim("role","admin"));
                options.AddPolicy("UserPolicy", policy => policy.RequireClaim("role","user","admin"));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MyDbContext context)
        {
            context.Database.Migrate();  // son migration alýp veritabanýn güncellemiþ oluyoruz. 

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles(); // css, js, image dosyalarýna wwwroot altýndan eriþebilmek için

            app.UseAuthentication();  // kimlik doðrulama 

            app.UseAuthorization(); // yetkilendirme

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "DefaultArea",
                   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                   );

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Auth}/{action=Login}/{id?}"
                    );


            });
        }
    }
}
