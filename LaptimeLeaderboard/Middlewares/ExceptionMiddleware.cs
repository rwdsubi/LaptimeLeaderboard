using LaptimeLeaderboard.Library.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptimeLeaderboard.Api.Middlewares
{
    internal class ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await this.next.Invoke(context);
            }
            catch (HttpException httpException)
            {
                context.Response.StatusCode = httpException.StatusCode;
                var responseFeature = context.Features.Get<IHttpResponseFeature>();
                responseFeature.ReasonPhrase = httpException.Message;
            }
            catch(LeaderboardException lbexception)
            {
                // log exception
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                var responseFeature = context.Features.Get<IHttpResponseFeature>();
                responseFeature.ReasonPhrase = lbexception.Message;
            }
            catch(Exception ex)
            {
                // log exception
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                var responseFeature = context.Features.Get<IHttpResponseFeature>();
                responseFeature.ReasonPhrase = "An unexpected error occured.";
            }
        }
    }
}
