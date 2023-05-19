using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekUygulamaMVC
{
    public class Startup
    {
        //MVC pipeline çalýþma sýralamsý dizisi

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //Service ve modülleri bu uygulamaya yüklediðimiz kýsým
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();//MVC pipeline çalýþma sýralamsý dizisi
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); //Gelen isteðin rotasý bu middleware sayesinde belirlenir

            //Endoint yapýlan isteðin varýþ noktasý.Url istek adresi
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
               // endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
               // endpoints.MapControllerRoute("Default", "{controller=Product}/{action=GetProducts}/{id?}");
                endpoints.MapControllerRoute("Default", "{controller=Product}/{action=CreateProduct}/{id?}");
                // endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
