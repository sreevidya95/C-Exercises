using Microsoft.Identity.Client;
using System.Net.Mime;
using System.Net;
using System.Text.Json;
using LocalGym.Models;
using Newtonsoft.Json;

namespace LocalGym
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await CustomHandleExceptionAsync(context, ex);

            }
        }
        public async Task CustomHandleExceptionAsync(HttpContext context,Exception e)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            if(e is IException ex)
            {
                if (ex.statusCode.HasValue)
                {
                    context.Response.StatusCode = (int)ex.statusCode.Value;
                    await context.Response.WriteAsync(new ExceptionModel().toJson());
                }
                else
                {
                    await context.Response.WriteAsync(JsonConvert.SerializeObject(new
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "something went wrong",
                    }));
                }

            }

        }
    }
}
