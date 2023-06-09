using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrnekUygulamaMVC.Handlers;

namespace OrnekUygulamaMVC
{
    public class Startup
    {
        //MVC pipeline �al��ma s�ralams� dizisi

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //Service ve mod�lleri bu uygulamaya y�kledi�imiz k�s�m
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();//MVC pipeline �al��ma s�ralams� dizisi
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); //Gelen iste�in rotas� bu middleware sayesinde belirlenir

            //Endoint yap�lan iste�in var�� noktas�.Url istek adresi
            app.UseEndpoints(endpoints =>
            {
                //endpoints.Map("example-route", async c =>
                //{
                //    //https://localhost:5001/example-route endpoints'e gelen herhangi bir istek controller'dan ziyade direkt olarak buradaki fonkdiyondan kar��lanacakt�r
                //});
                endpoints.Map("example-route", new ExampleHandler().Handler());
                endpoints.Map("image/{imageName}", new ImageHandler().Handler(env.WebRootPath));
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                // endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
                // endpoints.MapControllerRoute("Default", "{controller=Product}/{action=GetProducts}/{id?}");
                // endpoints.MapControllerRoute("Default", "{controller=Product}/{action=CreateProduct}/{id?}");
                //endpoints.MapControllerRoute("CustomRoute", "{controller=Home}/{action=Index}/{a}/{b}/{id}");
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
