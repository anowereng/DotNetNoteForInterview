using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MIddleware.API
{
    public class MyFirstCustomMiddleware 
    {
        private readonly RequestDelegate _next;
        private IPrint _print;
        public MyFirstCustomMiddleware(RequestDelegate next, IPrint print)
        {
            _print =  print;
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("custom middleware");
            await _next(context);
            _print.ExecPrint();
        }
    }
}
