using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BaseEntities.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using Repository.Repos;
using Services;
using Services.Interfaces;

namespace MVC
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

        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options => {
            options.LoginPath = "/Account/Login/";
            //401
            //options.Events.OnRedirectToLogin = (context) =>
            //{
            //    context.Response.StatusCode = 401;
            //    return Task.CompletedTask;
            //};
        });
            //Where the Login Path is the URL to your login page. 
            //Remember this page should be excluded from authorization checks!
            
            services.AddMvc();
            services.AddAutoMapper();
            services.AddDbContext<MyContext>
            (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddTransient<IGeneric<Category>, CategoryRepo>();
            services.AddTransient<IGeneric<TranslationEngEst>, EngEstRepo>();
            services.AddTransient<IGeneric<LangEnglish>, EngRepo>();
            services.AddTransient<IGeneric<TranslationEngRus>, EngRusRepo>();
            services.AddTransient<IGeneric<LangEstonian>, EstRepo>();
            services.AddTransient<IGeneric<PartOfSpeech>, PartOfSpeechRepo>();
            services.AddTransient<IGeneric<TranslationRusEst>, RusEstRepo>();
            services.AddTransient<IGeneric<LangRussian>, RusRepo>();
            services.AddTransient<IGeneric<Subcategory>, SubcategoryRepo>();

            services.AddTransient<IGenericService<Category>, CategoryService>();
            services.AddTransient< IGenericService < Subcategory > ,SubcategoryService >();
            services.AddTransient< IGenericService < PartOfSpeech > ,PartOfSpeechService >();
            services.AddTransient< IGenericService < LangEnglish > ,EngService >();
            services.AddTransient< IGenericService < LangEstonian >, EstService >();
            services.AddTransient< IGenericService < LangRussian >, RusService >();

            
            services.AddTransient<IGenericTranslate<TranslationEngEst>, EngEstService>();

            
            services.AddTransient<IGenericTranslate<TranslationEngRus>, EngRusService>();

            
            services.AddTransient<IGenericTranslate<TranslationRusEst>, RusEstService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                
            });
            
        }
    }
}
