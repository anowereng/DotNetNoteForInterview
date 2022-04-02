using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MIddleware.API
{
    public static class MyFirstExtension
    {
        public static void MyFirstExtensionRun(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Before Request");
                await next();
                await context.Response.WriteAsync("After Request");
            });

            app.Map("/role", a => {
                a.Run(

                    async (context) => await context.Response.WriteAsync("Hello role"));
            });

            app.Run(async (context) => await context.Response.WriteAsync("Hello Anower"));
        }
    }
}
