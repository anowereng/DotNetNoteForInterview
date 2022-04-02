using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MiddlewareException.API
{
    public class CustomExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await HandleExceptionAsync(context);

            }
        }

        private async Task HandleExceptionAsync(HttpContext context)
        {
            await context.Response.WriteAsync(
                 new APIResponse
                 {
                     Data = null,
                     Message = "Internal server error from custom middleware",
                     MessageType = Enum.GetName(typeof(MessageType),MessageType.Error),
                     StatusCode = (int)HttpStatusCode.InternalServerError
                 }.ToString());
        }
    }
}
