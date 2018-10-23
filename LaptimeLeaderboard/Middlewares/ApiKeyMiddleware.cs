using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Threading.Tasks;

namespace LaptimeLeaderboard.Api.Middlewares
{
    internal class ApiKeyMiddleware
    {
        private readonly RequestDelegate next;
        private string apiKey;

        public ApiKeyMiddleware(RequestDelegate next, IConfiguration cfg)
        {
            this.next = next;
            apiKey = cfg.GetSection("ApiKey").Value;
        }

        public async Task Invoke(HttpContext context)
        {
            bool IsApiCall = context.Request.Path.StartsWithSegments(new PathString("/api"));

            if(!IsApiCall || ApiKeyIsValid(context))
            {
                await this.next.Invoke(context);
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Invalid or Missing API Key");
            } 
        }

        private bool ApiKeyIsValid(HttpContext context)
        {
            var keyexists = context.Request.Query.TryGetValue("apiKey", out var queryKey);

            if (keyexists)
            {
                return queryKey == this.apiKey;
            }

            return false;
        }
    }
}
