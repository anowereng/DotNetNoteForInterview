using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIddleware.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPrint, Print>();
        }
        public void Configure(IApplicationBuilder app, ILogger<Startup> logger)
        {
            //app.UseWelcomePage(); // for dot net welcompage middleware;

            /* Example - 1
               [ app.run  =  app.run is terminal middleware . this middleware terminate middleware pipeline. shortly we said app.rn is end of pipeline .]
              app.Run(async (context) => await context.Response.WriteAsync("Hello Anower"));
              app.Run(async (context) => await context.Response.WriteAsync("Hello anower 2"));

             */

            /* Example - 2
             [ app.use  =  app.use but next not use so its behabe like app.run]

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Before Request");
            });
            app.Run(async (context) => await context.Response.WriteAsync("Hello Anower"));

            */

            /* Example - 3
            [ app.use  =  app.next use so its called next middleware in htt[ request pipeline]

              app.Use(async (context, next) =>
              {
                  await context.Response.WriteAsync("Before Request");
              });
              app.Run(async (context) => await context.Response.WriteAsync("Hello Anower"));

            */


            /* Example - 4
            [ app.use  =  app.next use so its called next middleware after request its called 

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Before Request");
                await next();
                await context.Response.WriteAsync("After Request");
            });
            app.Run(async (context) => await context.Response.WriteAsync("Hello Anower"));

            */

            /* Example - 5


              app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Before Request");
                await next();
                await context.Response.WriteAsync("After Request");
            });

            app.UseWhen(c => c.Request.Query.ContainsKey("role"), a=> {
                a.Run(

                    async (context) => await context.Response.WriteAsync("Hello role"));
            });

            app.Run(async (context) => await context.Response.WriteAsync("Hello Anower"));

            */

            /* Example - 6

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Before Request");
                await next();
                await context.Response.WriteAsync("After Request");
            });

            app.Map("/role", a=> {
                a.Run(

                    async (context) => await context.Response.WriteAsync("Hello role"));
            });

            app.Run(async (context) => await context.Response.WriteAsync("Hello Anower"));

            */

            // Example - 7 [ code maintain other cs file ]
            //app.MyFirstExtensionRun();

            // Example - 8 [ custom middleware ]
            app.UseMiddleware<MyFirstCustomMiddleware>();
            app.Run(async (context) => await context.Response.WriteAsync("Hello anower 2"));

        }
    }
}
