using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MYFirstASPNETCoreWebApp.Middleware;

namespace MYFirstASPNETCoreWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMyCustomMiddleware();
            app.UseStaticFiles();

            app.MapWhen(context => context.Request.QueryString.Value.Contains("abc"), app1 =>
            {
                app1.Run(async context =>
                {
                    await context.Response.WriteAsync("with abc query");
                });
            });

            app.Map("/hello", app1 =>
            {
                app1.Run(async context =>
                {
                    await context.Response.WriteAsync("hello requested");
                });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1>Hello World!</h1>");
            });
        }
    }
}
