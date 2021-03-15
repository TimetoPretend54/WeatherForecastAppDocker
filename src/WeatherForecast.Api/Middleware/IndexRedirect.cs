namespace WeatherForecast.Api.Middleware
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Http;
    using System.IO;

    public class IndexRedirect
    {
        private readonly RequestDelegate next;

        public IndexRedirect(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await next(httpContext);

            if (httpContext.Response.StatusCode == 404
                && !Path.HasExtension(httpContext.Request.Path.Value)
                && !httpContext.Request.Path.Value.StartsWith("/api/")
            )
            {
                httpContext.Request.Path = "/index.html";

                await next(httpContext);
            }
        }
    }

    public static class IndexRedirectExtensions
    {
        public static IApplicationBuilder UseIndexRedirect(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<IndexRedirect>();
        }
    }
}
